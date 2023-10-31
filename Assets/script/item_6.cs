using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_6 : MonoBehaviour
{
    public GameObject item_7;
    public GameObject ob;

    int count;
    void Start()
    {
        count = FindObjectOfType<GameManager>().setCount();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("so_6"))
        {
            Vector2 collisionPosition = collision.GetContact(0).point;            
            Destroy(ob);
            if (getCount() > collision.gameObject.GetComponent<item_6>().getCount()) {
                FindObjectOfType<GameManager>().setItem(item_7, collisionPosition);
            }
        }     
    }

    public int getCount() {
        return count;
    }
}
