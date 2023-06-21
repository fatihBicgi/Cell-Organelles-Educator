using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject SpawnableObject;

    [SerializeField] private List<Transform> spawnPoints = new List<Transform>();

    private int lastIndex = 0;

    private float currentTime = 0f;
    [SerializeField] private float MaxTime = 3f;

    void Start()
    {        
        int objectCount = 0;

        foreach (Transform child in gameObject.transform)
        {
            objectCount++;
            spawnPoints.Add(child.transform);
        }

        lastIndex = objectCount;
    }

    void Update()
    {

        currentTime += Time.deltaTime;

        if (MaxTime < currentTime)
        {
            currentTime = 0;

            SpawnObject();

        }

        
    }

    private void SpawnObject()
    {
        int randomNumber = Random.Range(0, lastIndex);

        GameObject foodSpawn = Instantiate(SpawnableObject, spawnPoints[randomNumber].position, spawnPoints[randomNumber].rotation);
    }
}
