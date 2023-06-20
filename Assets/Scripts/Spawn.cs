using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject foodObject;
    [SerializeField] private Transform spawnPoint0;
    // 8 tane spawn noktasý ekle
    // bunlarda spawn olan objeleri randomize et

    private float currentTime = 0f;
    [SerializeField] private float MaxTime = 3f;

    void Start()
    {
        
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
        GameObject foodSpawn = Instantiate(foodObject, spawnPoint0.position, spawnPoint0.rotation);
    }
}
