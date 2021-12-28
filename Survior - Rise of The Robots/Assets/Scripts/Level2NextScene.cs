using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2NextScene : MonoBehaviour
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
