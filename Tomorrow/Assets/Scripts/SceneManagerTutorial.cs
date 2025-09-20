using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagerTutorial : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPauseScreen()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void ReturnTutorial()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }

    public void NextTutorialOne()
    {
        SceneManager.LoadScene("TutorialOne");
    }

    public void GoBackTutorialZero()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
