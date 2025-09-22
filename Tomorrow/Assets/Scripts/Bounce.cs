using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounciness = 5.0f;
    private Rigidbody2D rb;
    private AudioSource [] sounds;
    [SerializeField] private bool isTouchFloor = false;
    [SerializeField] private Animator anim;

    public bool IsTouchingFloor
    {
        get { return isTouchFloor; }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sounds = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            anim.SetBool("IsSquash", true);
            BounceThis();
            isTouchFloor = true;
            transform.localEulerAngles = new Vector3(0, 0, 0);  
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isTouchFloor = false;
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
