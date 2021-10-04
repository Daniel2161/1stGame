using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnShapes : MonoBehaviour
{
    public GameObject[] obstacleSpawnerPrefab; 
    public float spawnTime = 1f;
    public float timer = 0; 

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnTime)
        {
            int rand = Random.Range(0, obstacleSpawnerPrefab.Length);

            
            GameObject obs = Instantiate(obstacleSpawnerPrefab[rand]);
            obs.transform.position = transform.position + new Vector3(0,-2,0);
            Destroy(obs, 2);
            timer = 0; 
        }
        timer += Time.deltaTime; 
    }
}
