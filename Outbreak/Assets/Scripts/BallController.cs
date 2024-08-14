using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 3f; // Initial speed of the ball
    private float maxSpeed = 20f; // Maximum speed the ball can reach
    private Vector2 direction; // The current direction of the ball's movement

    

    private void Start()
    {
        // Set the initial direction of the ball to a downward angle
        direction = new Vector2(Random.Range(-1f, 2f), -1f).normalized; // Start at a random angle downwards
    }

    private void Update()
    {
        // Move the ball in the current direction
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // This method is called when the ball collides with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reflect the ball's direction based on the collision's normal vector
        direction = Vector2.Reflect(direction, collision.contacts[0].normal);

        // Increase the ball's speed after colliding with an object
        if (speed < maxSpeed)
        {
            speed += 0.5f; // Increment speed gradually after each collision
        }

        if (collision.gameObject.tag == "Block")
        {
            Destroy(collision.gameObject);
            Debug.Log("Block");
        }
    }
}
