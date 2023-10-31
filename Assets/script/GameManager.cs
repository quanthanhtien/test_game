using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] objects;
    bool ready = true;
    public GameObject[] icons;
    int count = 0;
    int i;
    bool mouseClicked = false;

    void Update()
    {
        if (ready == true && !mouseClicked)
    {
        i = Random.Range(0, objects.Length);
        icons[i].SetActive(true);
        mouseClicked = true;
    }

    if (Input.GetMouseButtonDown(0) && ready == true)
    {
        // Xử lý khi nhấp chuột
        icons[i].SetActive(false);
        ready = false;
        Vector3 touchs = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        touchs.z = 0;
        Vector2 newPoint = new Vector2(touchs.x, 3.77f);
        Instantiate(objects[i], newPoint, Quaternion.identity);
        count++;
        mouseClicked = false; // Đặt lại biến mouseClicked thành false để cho phép ngẫu nhiên một lần nữa
    }
        
    }

    public int setCount() {
        return count;
    }    
    public void setReady() {
        ready = true;
    }
    public void setItem(GameObject obj, Vector2 point) {
        Instantiate(obj, point, Quaternion.identity);
    }
    
}