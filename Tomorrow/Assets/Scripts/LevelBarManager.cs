using UnityEngine.UI;
using UnityEngine;

public class LevelBarManager : MonoBehaviour
{
    [SerializeField] private Image revImage;
    [SerializeField] private Image sinImage;
    private float maxBar = 100;
    private float minBar = 0;
    private float revBar = 0;
    private float sinBar = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float RevBar
    {
        get { return revBar; }
    }

    public float SinBar
    {
        get { return sinBar; }
    }

    void Start()
    {
        revImage.fillAmount = 0;
        sinImage.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRevBar()
    {
        revBar += 50;
        revBar = Mathf.Clamp(revBar, minBar, maxBar);
        revImage.fillAmount = revBar /100;
    }

    public void RestartRevBar()
    {
        revBar = 0;
        revImage.fillAmount = 0;
    }

    public void SetSinBar()
    {
        Debug.Log("SetSinBar");
        sinBar += 5;
        sinImage.fillAmount = sinBar /100;
    }

    public void RestartSinBar()
    {
        sinBar = 0;
        sinImage.fillAmount = 0;
    }
}
