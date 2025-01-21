using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector3 waypoint_A;
    [SerializeField] private Vector3 waypoint_B;

    private bool moveToPointA;
    private bool moveToPointB;


    private void Start()
    {
        Destroy(gameObject, 30);
    }


    private void Update()
    {
        transform.parent.position += Vector3.down * Time.deltaTime * 0.5f;


        if (!moveToPointA)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, waypoint_A, 0.01f);

            if (transform.localPosition == waypoint_A)
            {
                moveToPointA = true;
                moveToPointB = false;
            }
        }
        

        else if (!moveToPointB)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, waypoint_B, 0.01f);

            if (transform.localPosition == waypoint_B)
            {
                moveToPointA = false;
                moveToPointB = true;
            }
        }
    }
}
