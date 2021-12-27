using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int health;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed;
    private float timebtwShots;
    public float startTimebtwShots;
    public GameObject shot;
    public Transform firePoint;
    public GameObject healthdrop;
    public Transform healthdropPoint;
    


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        timebtwShots = startTimebtwShots;
        
    }
    private void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        if (timebtwShots <= 0)
        {
            Instantiate(shot, firePoint.position, firePoint.rotation);
            timebtwShots = startTimebtwShots;
        }
        else
        {
            timebtwShots -= Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        moveChar(movement);
    }

    void moveChar(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    public void TakeDamage(int dam)
    {
        health -= dam;
        if (health <= 0)
        {
            Die();
            Instantiate(healthdrop, healthdropPoint.position, Quaternion.identity);
        }
    }
    void Die()
    {
        Destroy(gameObject);
        
    }
    
}
