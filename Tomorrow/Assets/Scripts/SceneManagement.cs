using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] private GameObject reviveScreen;
    [SerializeField] private GameObject dieScreen;
    [SerializeField] private GameObject pauseScreen;
    private DayCounter dayCounter;
    [SerializeField] private TextMeshProUGUI dayDisplayer;
    [SerializeField] private TextMeshProUGUI dayAliveDisplayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dayCounter = GetComponent<DayCounter>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetDayText()
    {
        dayDisplayer.text = "Day " + dayCounter.Day.ToString();
    }

    public void SetReviveScreen(bool set)
    {
        reviveScreen.SetActive(set);
    }

    public void SetDieScreen(bool set)
    {
        dayAliveDisplayer.text = dayCounter.Day.ToString() +" Days";
        dieScreen.SetActive(set);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);

    }

    public void Return()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);

    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }



}
