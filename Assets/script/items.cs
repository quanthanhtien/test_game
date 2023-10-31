using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
    bool colider = true;
   private void OnCollisionEnter2D(Collision2D collision)
    {   if (colider != false) {
        if (collision.gameObject.layer == LayerMask.NameToLayer("item") || collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            colider = false;
            FindObjectOfType<GameManager>().setReady();
        }     
    } 
    }
}