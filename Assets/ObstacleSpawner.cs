using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject obstaclePrefab;

    //private float timeToSpawn = 2f;

    //public float timeBetweenSpawns = 1f;


// Update is called once per frame
//void Update()
//{
//        if (Time.time >= timeToSpawn)
//        {
//            SpawnObstacles();
//            timeToSpawn = Time.time + timeBetweenSpawns;

//        }
//    }
// Start is called before the first frame update

    // FixedUpdate and Update cause the blocks to fly into the sky creating a sprinkler/waterfall effect
void Start()
{
    int randomIndex = Random.Range(0, spawnPoints.Length);

    for (int i = 0; i < spawnPoints.Length; i++)
    {
            if (randomIndex != i && randomIndex != i+1)
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
            }

           

    }
}
}



