using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f; // Speed at which the ball moves
    private float maxspeed = 25f;
    private Vector3 direction = Vector3.down; // Initial direction of movement (to the right)

    // Update is called once per frame
    void Update()
    {
        // Move the ball in the current direction
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // This method is called when the ball collides with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reverse the direction upon collision
        if (speed  < maxspeed) 
        {
            speed += 1;
        }
        
        direction = -direction;
    }
}

