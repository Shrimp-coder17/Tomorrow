using UnityEngine;

public class DayCounter : MonoBehaviour
{
    [SerializeField] private float timer = 0f;
    [SerializeField] private float oneDay = 10f;
    [SerializeField] private int day = 0;
    private SceneManagement sceneManagement;

    public int Day
    {
        get { return day;}
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneManagement = GetComponent<SceneManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= oneDay)
        {
            day++;
            sceneManagement.SetDayText();
            timer = 0;
        }
    }
}
