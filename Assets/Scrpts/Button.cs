using UnityEngine;

public class TapToStart : MonoBehaviour
{
    public PongBall ball;  // Reference to your PongBall script

    void Start()
    {
        // Pause game at the beginning
        Time.timeScale = 0f;

        // Disable ball movement
        if (ball != null)
            ball.enabled = false;
    }

    void Update()
    {
        // Check for left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Resume game
            Time.timeScale = 1f;

            // Enable ball
            if (ball != null)
                ball.enabled = true;

            // Destroy this object (the "Tap to Start" text/panel/etc.)
            Destroy(gameObject);
        }
    }
}

