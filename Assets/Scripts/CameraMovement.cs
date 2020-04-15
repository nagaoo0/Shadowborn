using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{

    public GameObject player;
    //public GameObject startPos;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = startPos.transform.position;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player != null){
            Vector2 offset = player.GetComponent<Controller>().look* 1.5f;

            Vector3 pos = new Vector3(  Mathf.Clamp(player.transform.position.x + offset.x, minX, maxX),
                                        Mathf.Clamp(player.transform.position. y + offset.y, minY, maxY), 
                                        -10);
            transform.position = Vector3.Lerp(transform.position, pos, 0.1f);
        } else {
            player = GameObject.FindWithTag("Player");
        }       
    }
}
