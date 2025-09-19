using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounciness = 5.0f;
    private Rigidbody2D rb;
    [SerializeField] private Animator anim;
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
        if (collision.gameObject.CompareTag("Floor"))
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
            anim.SetBool("IsSquash", true);
            BounceThis();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            anim.SetBool("IsSquash", false);
        }
    }

    public void BounceThis()
    {
        Vector2 bounce = new Vector2(0, bounciness);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
        rb.AddForce(bounce, ForceMode2D.Impulse);
    }

    


}
