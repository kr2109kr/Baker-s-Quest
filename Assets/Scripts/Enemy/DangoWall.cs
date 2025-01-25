using UnityEngine;
using System.Collections;

public class DangoWall : MonoBehaviour
{
    [SerializeField] private Side side;
    [SerializeField] private float posX_A;
    [SerializeField] private float posX_B;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float holdTime;


    private enum Side
    {
        Left,
        Right
    }


    private void Start()
    {
        StartCoroutine(MoveToA());
    }


    IEnumerator MoveToA()
    {
        yield return new WaitForSecondsRealtime(holdTime);


        while (transform.localPosition.x != posX_A)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(posX_A, transform.localPosition.y), moveSpeed);
            yield return null;
        }


        StartCoroutine(MoveToB());
    }


    IEnumerator MoveToB()
    {
        yield return new WaitForSecondsRealtime(holdTime);

        while (transform.localPosition.x != posX_B)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(posX_B, transform.localPosition.y), moveSpeed);
            yield return null;
        }

        StartCoroutine(MoveToA());
    }
}
