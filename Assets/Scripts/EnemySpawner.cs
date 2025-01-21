using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector2 spawnPosition;


    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 7, 7);
    }


    private void SpawnEnemy()
    {
        Instantiate(prefab, spawnPosition, transform.rotation);
    }
}
