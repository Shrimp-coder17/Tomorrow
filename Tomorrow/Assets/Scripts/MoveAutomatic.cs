using UnityEngine;

public class MoveAutomatic : MonoBehaviour
{
    private float speedOne = -3f;
    private float speedTwo = -5f;
    private float speedThree = -6f;
    private float speedFour = -8f;
    [SerializeField] private float speed = -3f;
    private GameObject background;
    private DayCounter dayCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        background = GameObject.FindGameObjectWithTag("Background");
        dayCounter = background.GetComponent<DayCounter>();
        if(dayCounter.Day == 5)
        {
            speed = speedOne;
        }
        else if(dayCounter.Day == 8)
        {
            speed = speedTwo;
        }
        else if(dayCounter.Day == 10)
        {
            speed = speedThree;
        }
        else if(dayCounter.Day > 10)
        {
            speed = speedFour;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
