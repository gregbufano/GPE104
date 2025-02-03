using UnityEngine;

public class Move_Sprite : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;

        // Check for movement input
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveX = -speed; // Move left
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveX = speed; // Move right
        }

        // Apply velocity for movement, allowing gravity to handle falling
        rb.linearVelocity = new Vector2(moveX, rb.linearVelocity.y);
    }
        
    
}
