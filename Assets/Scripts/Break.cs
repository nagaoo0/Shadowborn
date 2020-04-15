using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("pickup")){
            Debug.Log("Break");
            gameObject.SetActive(false);
        }
    }

}
