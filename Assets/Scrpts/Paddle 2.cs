using UnityEngine;

public class Paddle2 : MonoBehaviour
{
    public float speed = 5f;
    public float minY = -4.25f;
    public float maxY = 4.25f;

    void Update()
    {
        float moveY = 0f;

        // O = Up, L = Down
        if (Input.GetKey(KeyCode.O))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            moveY = -1f;
        }

        // Apply movement
        transform.Translate(Vector3.up * moveY * speed * Time.deltaTime);

        // Clamp Y position
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}
