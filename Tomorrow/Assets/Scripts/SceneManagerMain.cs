using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagerMain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Debug.Log("Starting game!");
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game!");
        Application.Quit();
    }
}
