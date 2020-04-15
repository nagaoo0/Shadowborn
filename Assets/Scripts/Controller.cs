using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
    public GameObject handSocket;
    public GameObject spawn;
    public GameObject cam;

    private Rigidbody2D rb;
    private Animator animator;

    //INPUT
    public PlayerInput controls;
    public Vector2 move;
    public Vector2 look;

    private Gamepad gamepad = Gamepad.current;
    private Transform ventNear;
    private bool m_FacingRight;

    private bool isDashing = false;

    private bool nextToVent = false;

    private bool pickupInRange = false;
    private bool pickupHolding = false;
    private GameObject pickup;

    void OnEnable () {
        controls.input.Enable ();
    }
    void OnDisable () {
        controls.input.Disable ();
    }

    void Awake () {
        //SETTING UP CONTROLS
        controls = new PlayerInput ();

        controls.input.Move.performed += ctx => move = ctx.ReadValue<Vector2> ();
        controls.input.Move.canceled += ctx => move = Vector2.zero;
        controls.input.Look.performed += ctx => look = ctx.ReadValue<Vector2> ();
        controls.input.Look.canceled += ctx => look = Vector2.zero;

        controls.input.Attack.started += ctx => OnAttack ();
        controls.input.Attack.performed += ctx => OnAttackEnd ();
        controls.input.Interact.performed += ctx => Interact ();
        controls.input.Throw.performed += ctx => ThrowItem ();

    }

    void Start () {
        rb = gameObject.GetComponent<Rigidbody2D> ();
        animator = gameObject.GetComponent<Animator> ();

        Gamepad.current.SetMotorSpeeds (0.25f, 0.75f);
        InputSystem.PauseHaptics ();
    }

    void OnAttack () {
        if (!isDashing && move.x != 0) {
            isDashing = true;
            rb.AddForce (transform.right * 120f);
        }
    }

    void OnAttackEnd () {
        isDashing = false;
        rb.velocity = new Vector2 (0, rb.velocity.y);
    }

    void Interact () {

        //UTiliser les vents
        if (nextToVent && !pickupInRange) {

            transform.position = ventNear.position;

        }

        //Pickup item
        if (pickupInRange) {
            //Disable Collision and gravity
            Collider2D col = pickup.GetComponent<Collider2D> ();
            Rigidbody2D rb = pickup.GetComponent<Rigidbody2D> ();
            col.enabled = false;
            rb.isKinematic = true;
            //Put object in hand
            pickup.transform.SetParent (handSocket.transform, false);
            pickup.transform.position = handSocket.transform.position;
            pickup.transform.rotation = handSocket.transform.rotation;
            pickupHolding = true;
        }
    }

    void ThrowItem () {
        //Lauch item in hand
        if (pickupHolding) {
            //Reenable gravity
            Rigidbody2D rb = pickup.GetComponent<Rigidbody2D> ();
            rb.isKinematic = false;
            //Unparent and set the current position
            pickup.transform.SetParent (null, true);
            pickup.transform.position = handSocket.transform.position;
            //launch with to target look

            if (look == Vector2.zero) {
                pickupHolding = false;
                Collider2D col = pickup.GetComponent<Collider2D> ();
                col.enabled = true;

                pickup = null;
            } else {
                rb.AddForce (Mathf.Abs (look.x) * transform.right + transform.up * Mathf.Abs (look.y));
                rb.angularVelocity = Random.Range(-10.0f, 10.0f);
            }
            pickupInRange = false;

        }
    }

    void Update () {
        Vector2 hMove = new Vector2 (move.x, 0);

        //Animator
        animator.SetFloat ("Speed", Mathf.Abs (rb.velocity.x));

        if (isDashing) {
            //Gamepad Vibrate
            InputSystem.ResumeHaptics ();

            animator.ResetTrigger ("NoDash");
            animator.SetTrigger ("Dash");
        } else {
            //Gamepad Vibrate
            InputSystem.PauseHaptics ();

            animator.ResetTrigger ("Dash");
            animator.SetTrigger ("NoDash");
        }

        //Pickup des items
        if (handSocket.transform.childCount > 0) {
            pickupHolding = true;
            if (pickup != null) {
                //Debug.Log ("item lost and found thank you dev <3");
                pickup = handSocket.transform.GetChild (0).gameObject;
                pickup.transform.position = handSocket.transform.position;
                pickup.transform.rotation = handSocket.transform.rotation;
            }

        }
    }

    void FixedUpdate () {
        // 'Move' code here
        Vector2 hMove = new Vector2 (move.x, 0);
        if (rb.velocity.magnitude < 1) {
            rb.AddForce (hMove * 20f);

            if (isDashing && rb.velocity.x < 1) isDashing = false;

        }

        //MIRROR
        if (look.x != 0) {
            if (look.x < 0.1) {
                m_FacingRight = true;
                transform.localRotation = Quaternion.Euler (0, 180, 0);
            } else
            if (look.x > -0.1) {
                m_FacingRight = false;
                transform.localRotation = Quaternion.Euler (0, 0, 0);
            }
        }

        if (move.x != 0) {
            if (move.x < -0.01) {
                m_FacingRight = true;
                transform.localRotation = Quaternion.Euler (0, 180, 0);

            }
            if (move.x > 0.01) {
                m_FacingRight = false;
                transform.localRotation = Quaternion.Euler (0, 0, 0);

            }
        }

    }

    //INTERACTION
    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.CompareTag ("Vent")) {
            Debug.Log ("next to vent ?");
            nextToVent = true;

            ventNear = other.GetComponent<Vent> ().destination.transform;
        }

        if (other.gameObject.CompareTag ("Respawn")) {
            Debug.Log ("dead");
            SceneManager.LoadScene ("GameScene");
        }

        if (other.gameObject.CompareTag ("pickup")) {
            pickupInRange = true;
            pickup = other.gameObject;
        }

        if (other.gameObject.CompareTag ("police")) {
            Debug.Log ("touch police");

            other.gameObject.GetComponent<PolicePatrol> ().dead = true;
        }
    }

    void OnTriggerExit2D (Collider2D other) {
        if (other.gameObject.CompareTag ("Vent")) {
            nextToVent = false;

            ventNear = other.GetComponent<Vent> ().destination.transform;
        }

        if (other.gameObject.CompareTag ("pickup")) {
            if (!pickupHolding) {
                pickupInRange = false;
                pickup = null;
            } else {
                if (other.gameObject == pickup) {
                    pickupHolding = false;
                    Collider2D col = pickup.GetComponent<Collider2D> ();
                    col.enabled = true;
                }
            }
        }
    }

}