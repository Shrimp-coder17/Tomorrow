using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] GameObject sceneManager;
    private SceneManagement sceneManagement;
    private bool leftWallCollision = false;
    private bool obstacleCollision = false;
    private bool isAlive = true;
    private LevelBarManager levelBarManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneManagement = sceneManager.GetComponent<SceneManagement>();
        levelBarManager = GetComponent<LevelBarManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(leftWallCollision && obstacleCollision)
        {
            Debug.Log("Player Dead!");
            Die();
        }
        if(levelBarManager.SinBar >= 100)
        {
            Debug.Log("Player Dead!");
            levelBarManager.RestartSinBar();
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LeftWall"))
        {
            leftWallCollision = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            obstacleCollision = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LeftWall"))
        {
            leftWallCollision = false;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            obstacleCollision = false;
        }
    }

    void Die()
    {
        Time.timeScale = 0f;
        leftWallCollision = false;
        obstacleCollision = false;
        isAlive = false;
        if(levelBarManager.RevBar >= 100)
        {
            sceneManagement.SetReviveScreen(true);
        }
        else
        {
            sceneManagement.SetDieScreen(true);
        }  
    }

    public void Revive()
    { 
        Time.timeScale = 1f;
        transform.position = new Vector3(0, 0, 0);
        isAlive = true;
        levelBarManager.RestartSinBar();
        levelBarManager.RestartRevBar();
        sceneManagement.SetReviveScreen(false);
    }

}

