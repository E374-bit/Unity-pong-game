using UnityEngine;
using TMPro; // Important for TextMeshPro

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text scoreText;   // Assign your TextMeshPro object here in Inspector
    public int score = 0;
    public float interval = 1.5f; // Every 1.5 seconds

    void Start()
    {
        // Start repeating AddScore every 1.5s
        InvokeRepeating("AddScore", interval, interval);
    }

    void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

