using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level4next : MonoBehaviour
{

    void loadover()
    {
    SceneManager.LoadScene("Ultron");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
    loadover();
    } 
}


