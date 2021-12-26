using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int value;
    //public enum objectpickup { HEALTHPICKUP };
    //public objectpickup currObj;
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Health.Playerhealth.healthPickup += value;
            Debug.Log(Health.Playerhealth.healthPickup);
        }
        Destroy(gameObject);
    }
}
