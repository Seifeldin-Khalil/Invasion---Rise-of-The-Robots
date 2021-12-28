using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level4next : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
void loadover()
{
    SceneManager.LoadScene("Ultron");
}

void OnTriggerEnter2D(Collider2D collider)
{
    loadover();
} 

