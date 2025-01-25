using UnityEngine;

public class EnemyBlock : MonoBehaviour
{
    [SerializeField] private float endPosY;
    [SerializeField] private float moveSpeed;
    private void Update()
    {
        transform.position += Vector3.down * moveSpeed * GameManager.gameManager.gameSpeed;

        if (transform.position.y == endPosY)
        {
            Destroy(gameObject);
        }
    }
}
