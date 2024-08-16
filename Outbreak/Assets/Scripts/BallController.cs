using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 3f; // Initial speed of the ball
    private float maxSpeed = 20f; // Maximum speed the ball can reach
    private Vector2 direction; // The current direction of the ball's movement

    private GameManager gameManager;
    private LevelCreator levelCreator;

    private void Start()
    {
        // Set the initial direction of the ball to a downward angle
        direction = new Vector2(Random.Range(-1f, 2f), -1f).normalized; // Start at a random angle downwards

        gameManager = FindObjectOfType<GameManager>();
        levelCreator = FindObjectOfType<LevelCreator>();
    }

    private void Update()
    {
        // Move the ball in the current direction
        transform.Translate(direction * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed -= 0.01f;
        }
    }

    // This method is called when the ball collides with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reflect the ball's direction based on the collision's normal vector. This line is by gpt
        direction = Vector2.Reflect(direction, collision.contacts[0].normal);

        // Increase the ball's speed after colliding with an object
        if (speed < maxSpeed && collision.gameObject.tag != "Wall")
        {
            speed += 0.5f; // Increment speed gradually after each collision
        }

        if (collision.gameObject.tag == "Block")
        {
            //destroy block
            gameManager.score += 100;
            levelCreator.totalBlockAmount--;
            Destroy(collision.gameObject);
            Debug.Log("Block");
        }
    }
}
