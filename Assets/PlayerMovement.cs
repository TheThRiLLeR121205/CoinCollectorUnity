using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float xMin = -8f, xMax = 8f, yMin = -4.5f, yMax = 4.5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);
        transform.Translate(movement * speed * Time.deltaTime);

        // Clamp position
        Vector3 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, xMin, xMax);
        clampedPos.y = Mathf.Clamp(clampedPos.y, yMin, yMax);
        transform.position = clampedPos;
    }
}
