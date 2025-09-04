using UnityEngine;

public class PaddleSelector : MonoBehaviour
{
    public MonoBehaviour aiScript;     // Drag your PongAI script here
    public MonoBehaviour playerScript; // Drag your PlayerPaddle script here

    void Start()
    {
        // Disable both at the beginning
        if (aiScript != null) aiScript.enabled = false;
        if (playerScript != null) playerScript.enabled = false;
    }

    void Update()
    {
        // Left click = AI
        if (Input.GetMouseButtonDown(0))
        {
            if (aiScript != null) aiScript.enabled = true;
            if (playerScript != null) playerScript.enabled = false;
        }

        // Right click = Player
        if (Input.GetMouseButtonDown(1))
        {
            if (aiScript != null) aiScript.enabled = false;
            if (playerScript != null) playerScript.enabled = true;
        }
    }
}
