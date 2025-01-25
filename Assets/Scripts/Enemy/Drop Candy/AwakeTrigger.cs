using UnityEngine;

public class AwakeTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DropCandy dropCandy = GetComponentInParent<DropCandy>();
            dropCandy.StartCoroutine("AwakeUp");
        }
    }
}
