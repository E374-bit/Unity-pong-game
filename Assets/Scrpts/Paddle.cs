using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 5f;
    public float minY = -4.25f;
    public float maxY = 4.25f;

    void Update()
    {
        // Get vertical input (W = 1, S = -1)
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        // Apply movement
        transform.Translate(Vector3.up * moveY * speed * Time.deltaTime);

        // Clamp the Y position
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}

