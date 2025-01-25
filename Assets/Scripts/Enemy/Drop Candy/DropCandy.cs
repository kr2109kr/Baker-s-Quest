using UnityEngine;
using System.Collections;

public class DropCandy : MonoBehaviour
{
    [SerializeField] private Sprite dropCandySprit_0;
    [SerializeField] private Sprite dropCandySprit_1;
    [SerializeField] private Sprite dropCandySprit_2;

    [SerializeField] private float awakePosY;
    [SerializeField] private float endPosY;
    [SerializeField] private float dropDownSpeed;
    [SerializeField] private float awakeUpSpeed;

    IEnumerator AwakeUp()
    {
        GetComponent<SpriteRenderer>().sprite = dropCandySprit_1;


        while (transform.localPosition.y != awakePosY)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(transform.position.x, awakePosY), dropDownSpeed);
            yield return null;
        }


        StartCoroutine(DropDown());
    }

    IEnumerator DropDown()
    {
        GetComponent<SpriteRenderer>().sprite = dropCandySprit_2;


        while (transform.localPosition.y != endPosY)
        {
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, new Vector2(transform.position.x, endPosY), dropDownSpeed);
            yield return null;
        }


        Destroy(gameObject);
    }

}
