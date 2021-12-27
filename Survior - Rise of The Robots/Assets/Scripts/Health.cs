using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static Health Playerhealth;
    
    public float maxHealth =100;
    public float health;
    public Slider HealthUI;
    public Gradient gradient;
    public Image fill;
    

    void Start()
    {
        health = maxHealth;
        fill.color = gradient.Evaluate(1f);
    }

    
    void Update()
    {
        HealthUI.value = health;
        fill.color = gradient.Evaluate(HealthUI.normalizedValue);
    }

    public void takeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
            // new line 
            (new NavigationController()).GoToGameOverScene();
        }
    }
    void Die()
    {
        Destroy(gameObject);
        HealthUI.value = 0;
    }

    public void healHealth(int heal)
    {
        health += heal;
        if (health >= 100)
        {
            health = maxHealth;
        }
    }

}
