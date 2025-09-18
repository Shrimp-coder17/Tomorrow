using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private LevelBarManager levelBarManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelBarManager = GetComponent<LevelBarManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ReviveOrb"))
        {
            levelBarManager.SetRevBar();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("SinOrb"))
        {
            levelBarManager.SetSinBar();
            Destroy(other.gameObject);
        }
    }

   
}
