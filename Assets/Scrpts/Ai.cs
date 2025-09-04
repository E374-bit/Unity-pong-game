using UnityEngine;

public class PongAI : MonoBehaviour
{
    public Transform ball;   // Reference to the ball
    public float speed = 6f; // Paddle move speed
    public float boundY = 4f; // Limit paddle movement (so it stays on screen)

    void Update()
    {
        if (ball == null) return;

        // If ball is above paddle → move up
        if (ball.position.y > transform.position.y)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        // If ball is below paddle → move down
        else if (ball.position.y < transform.position.y)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        // Clamp position so paddle doesn’t go off-screen
        float clampedY = Mathf.Clamp(transform.position.y, -boundY, boundY);
        transform.position = new Vector3(transform.position.x, clampedY, transform.position.z);
    }
}

