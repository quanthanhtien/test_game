using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class quit : MonoBehaviour
{
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape)) {
            LoadQuit(); 
        }
    }
    public void LoadQuit() {
        Application.Quit();
        Debug.Log("QUIT ");
    }
}
