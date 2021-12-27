using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Loselvl2Scene2 : MonoBehaviour
{


    void loadover()
    {
        SceneManager.LoadScene("Level2Scene2");
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        loadover();
    }
}
