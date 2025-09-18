using UnityEngine;

[RequireComponent(typeof(Bounce))]
public class ChangeMassByInput : MonoBehaviour
{
    private float firstMass = 0.4f;
    private float secondMass = 0.48f;
    private float thirdMass = 0.8f;
    private float fourthMass = 10f;
    private Rigidbody2D rb;
    private float originalMass;
    private Bounce bounce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bounce = GetComponent<Bounce>();
        if (rb!=null)
        {
            originalMass = rb.mass;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            rb.mass = firstMass;

        }
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            rb.mass = originalMass;

        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            rb.mass = secondMass;

        }
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            rb.mass = originalMass;

        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            rb.mass = thirdMass;

        }
        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            rb.mass = originalMass;

        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            rb.mass = fourthMass;
        }
        if (Input.GetKeyUp(KeyCode.KeypadEnter))
        {
            //bounce.BounceThis();
            rb.mass = originalMass;
        }
    }
    
}
