using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagerMain : MonoBehaviour
{
    private AudioSource buttonSounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonSounds = GetComponent<AudioSource>();
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

    public void GoTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game!");
        Application.Quit();
    }

    public void PlayButtonSounds()
    {
        buttonSounds.Play();
    }
}
