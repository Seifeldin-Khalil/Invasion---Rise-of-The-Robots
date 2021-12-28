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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            loadover();
        }

    }
}


