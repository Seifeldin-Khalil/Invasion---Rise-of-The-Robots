using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Lvl3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void loadover()
    {
        SceneManager.LoadScene("Scene1");
    }

    void OnTriggerEnter2D(Collider2D collisder)
    {
        loadover();
    }
}
