using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_3 : MonoBehaviour
{
    public GameObject item_4;
    public GameObject ob;

    int count;
    void Start()
    {
        count = FindObjectOfType<GameManager>().setCount();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("so_3"))
        {
            Vector2 collisionPosition = collision.GetContact(0).point;            
            Destroy(ob);
            if (getCount() > collision.gameObject.GetComponent<item_3>().getCount()) {
                FindObjectOfType<GameManager>().setItem(item_4, collisionPosition);
            }
        }     
    }

    public int getCount() {
        return count;
    }
}
