using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_8 : MonoBehaviour
{
    public GameObject item_9;
    public GameObject ob;

    int count;
    void Start()
    {
        count = FindObjectOfType<GameManager>().setCount();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("so_8"))
        {
            Vector2 collisionPosition = collision.GetContact(0).point;            
            Destroy(ob);
            if (getCount() > collision.gameObject.GetComponent<item_8>().getCount()) {
                FindObjectOfType<GameManager>().setItem(item_9, collisionPosition);
            }
        }     
    }

    public int getCount() {
        return count;
    }
}
