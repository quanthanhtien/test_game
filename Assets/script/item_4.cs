using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_4 : MonoBehaviour
{
    public GameObject item_5;
    public GameObject ob;

    int count;
    void Start()
    {
        count = FindObjectOfType<GameManager>().setCount();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("so_4"))
        {
            Vector2 collisionPosition = collision.GetContact(0).point;            
            Destroy(ob);
            if (getCount() > collision.gameObject.GetComponent<item_4>().getCount()) {
                FindObjectOfType<GameManager>().setItem(item_5, collisionPosition);
            }
        }     
    }

    public int getCount() {
        return count;
    }
}
