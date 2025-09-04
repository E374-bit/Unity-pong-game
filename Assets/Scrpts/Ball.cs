using UnityEngine;
using UnityEngine.SceneManagement;

public class PongBall : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Pick a random start direction
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.Range(-0.7f, 0.7f);
        direction = new Vector2(x, y).normalized;

        rb.velocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Finish"))
        {
            // Reload scene if we hit Finish
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            // Reflect ball based on collision normal
            direction = Vector2.Reflect(direction, collision.contacts[0].normal).normalized;
            rb.velocity = direction * speed;
        }
    }
}
