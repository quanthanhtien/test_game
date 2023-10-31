using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_9 : MonoBehaviour
{
    public GameObject ob;

    int count;
    void Start()
    {
        count = FindObjectOfType<GameManager>().setCount();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("so_9"))
        {
            Vector2 collisionPosition = collision.GetContact(0).point;            
            Destroy(ob);
        }     
    }

    public int getCount() {
        return count;
    }
}
