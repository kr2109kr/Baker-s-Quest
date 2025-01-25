using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Vector2 spawnPosition;
    [SerializeField] private List<GameObject> enemyBlocks = new();

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 2.5f);
    }


    private void SpawnEnemy()
    {
        Instantiate(enemyBlocks[Random.Range(0, enemyBlocks.Count)], spawnPosition, transform.rotation);
    }

}
