using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("yy");
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("XX");
            Destroy(gameObject);
        }
    }
}
