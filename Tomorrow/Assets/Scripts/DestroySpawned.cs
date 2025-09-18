using UnityEngine;

public class DestroySpawned : MonoBehaviour
{
    private float destroyPointXFromRight = -14.0f;
    private float destroyPointXFromLeft = 14.0f;
    private float destroyPointX;
    public bool movable = false;
    public bool fromLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (fromLeft)
        {
            destroyPointX = destroyPointXFromLeft;
        }
        else
        {
            destroyPointX = destroyPointXFromRight;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (fromLeft)
        {
            if (transform.position.x >= destroyPointX)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            if (transform.position.x <= destroyPointX)
            {
                Destroy(this.gameObject);
            }
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
