using UnityEngine;

public class MoveAutomatic : MonoBehaviour
{
    private float speedOne = -3f;
    private float speedTwo = -4f;
    private float speedThree = -5f;
    private float speedFour = -6f;
    [SerializeField] private float speed = -3f;
    private GameObject background;
    private DayCounter dayCounter;
    public bool fromLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (fromLeft)
        {
            SetFromLeft();
        }
        background = GameObject.FindGameObjectWithTag("Background");
        dayCounter = background.GetComponent<DayCounter>();
        if (!fromLeft)
        {
            if (dayCounter.Day == 5)
            {
                speed = speedOne;
            }
            else if (dayCounter.Day == 8)
            {
                speed = speedTwo;
            }
            else if (dayCounter.Day == 10)
            {
                speed = speedThree;
            }
            else if (dayCounter.Day > 10)
            {
                speed = speedFour;
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void SetFromLeft()
    {
        speed = 3f;
        speedOne = Mathf.Abs(speedOne);
        speedTwo = Mathf.Abs(speedTwo);
        speedThree = Mathf.Abs(speedThree);
        speedFour = Mathf.Abs(speedFour);
    }
}
