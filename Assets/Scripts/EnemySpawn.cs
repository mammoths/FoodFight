using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public Transform spawnLocation;
    public GameObject enemyPrefab;
    public float SpawnTime;

    

    bool spawner = true;
    // Use this for initialization
    void Start()
    {
        SpawnTime = 10;
        StartCoroutine(NewEnemySpawn());

    }

    IEnumerator NewEnemySpawn()
    {
        while (spawner)
        {

            Instantiate(enemyPrefab, spawnLocation.position, spawnLocation.localRotation);
            yield return new WaitForSeconds(SpawnTime);

            
        }


    }


}
