using UnityEngine;

public class DestroySpawned : MonoBehaviour
{
    private float destroyPointX = -14.0f;
    public bool movable = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= destroyPointX)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (movable)
        {
            if (collision.gameObject.CompareTag("Floor"))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
