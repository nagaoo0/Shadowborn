using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolicePatrol : MonoBehaviour
{
    public float speed;
    public float pace;
    public bool m_Facing = true;
    public GameObject lightkill;

    public bool dead = false;

    private Rigidbody2D rb;
    private Animator animator;

   void Start()
    {
        rb= gameObject.GetComponent<Rigidbody2D>();
        animator= gameObject.GetComponent<Animator>();
    }

    void Update()
    {
         if(m_Facing){
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                rb.velocity= new Vector2(0,0);
            } else {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                rb.velocity= new Vector2(0,0);
            }

        if(!dead){
           

            if(rb.velocity.magnitude < speed){
                rb.AddForce(pace * transform.right);
            }
            
        }else{
            animator.SetTrigger("Die");
            
                 Collider2D col = gameObject.GetComponent<Collider2D>();
                Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
                col.enabled = false;
                rb.isKinematic = true;
            col.enabled = false;
            lightkill.SetActive(false);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Wall")){
            m_Facing = !m_Facing;
        }
    }
}
