using UnityEngine;

public class MoveInput : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 6f;
    private float YPosMoveLimit = -3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    { 
        if(transform.position.y > YPosMoveLimit)
        {
            float deltaX = Input.GetAxis("Horizontal");
            Vector2 movement = new Vector2(deltaX*speed, rb.linearVelocity.y);
            rb.linearVelocity = movement;
        } 
    }
}
