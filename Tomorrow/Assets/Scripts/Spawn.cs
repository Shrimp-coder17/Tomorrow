using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject obstacle1;
    [SerializeField] private GameObject obstacle2;
    [SerializeField] private GameObject obstacle3;
    [SerializeField] private GameObject obstacle4;
    [SerializeField] private GameObject orbRevive;
    [SerializeField] private GameObject orbSin;
    private List<GameObject> obstacles = new List<GameObject>();
    private List<GameObject> orbs = new List<GameObject>();
    private GameObject obj;
    private float xPosObstacle = 12f;
    private float yPosObstacle = 0f;
    private float xPosOrbsMin = 8f;
    private float xPosOrbsMax = 25f;
    private float yPosOrbsMin = -3f;
    private float yPosOrbsMax = 3f;
    [SerializeField] private float timer = 0f;
    private float timeSpawnIntervals = 5f;
    private DayCounter dayCounter;
    private bool isAddedObstacleFour = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dayCounter = GetComponent<DayCounter>();
        obstacles.Add(obstacle1);
        obstacles.Add(obstacle2);
        obstacles.Add(obstacle3);
        orbs.Add(orbRevive);
        orbs.Add(orbSin);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        addNewObstacles();
        if (timer >= timeSpawnIntervals)
        {
            if(Random.Range(0, 2) == 1)
            {
                SpawnRandomFixedPos();
            }
            else
            {
                for(int x = 0; x<10; x++)
                {
                    SpawnRandom();
                }
            } 
            timer = 0;
        }
    }

    private void SpawnRandomFixedPos()
    {
        int RandomIndex = Random.Range(0, obstacles.Count);
        obj = Instantiate(obstacles[RandomIndex]) as GameObject;
        obj.transform.position = new Vector3(xPosObstacle, yPosObstacle, 0f);
    }

    private void SpawnRandom()
    {
        int RandomIndex = Random.Range(0, orbs.Count);
        obj = Instantiate(orbs[RandomIndex]) as GameObject;
        obj.transform.position = RandomPos2D(xPosOrbsMin, xPosOrbsMax, yPosOrbsMin, yPosOrbsMax);
    }

    private Vector3 RandomPos2D(float xMin, float xMax, float yMin, float yMax)
    {
        float x = Random.Range(xMin, xMax);
        float y = Random.Range(yMin, yMax);
        return new Vector3(x, y, 0f);
    }

    private void addNewObstacles()
    {
        if(dayCounter.Day == 5)
        {
            if (!isAddedObstacleFour)
            {
                obstacles.Add(obstacle4);
                isAddedObstacleFour = true;
            }
   
        }
    }
}
