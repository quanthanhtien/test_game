using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_2 : MonoBehaviour
{
    public GameObject item_3;
    public GameObject ob;

    int count;
    void Start()
    {
        count = FindObjectOfType<GameManager>().setCount();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("so_2"))
        {
            Vector2 collisionPosition = collision.GetContact(0).point;            
            Destroy(ob);
            if (getCount() > collision.gameObject.GetComponent<item_2>().getCount()) {
                FindObjectOfType<GameManager>().setItem(item_3, collisionPosition);
            }
        }     
    }

    public int getCount() {
        return count;
    }
}
