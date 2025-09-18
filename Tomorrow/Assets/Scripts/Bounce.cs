using UnityEngine;

public class Bounce : MonoBehaviour
{
    public string surfaceTag;
    public float bounciness = 5.0f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(surfaceTag))
        {
            BounceThis();
        }
    }

    public void BounceThis()
    {
        Vector2 bounce = new Vector2(0, bounciness);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
        rb.AddForce(bounce, ForceMode2D.Impulse);
    }

    


}
