using UnityEngine;
using System.Collections;

public class SurprisePun : MonoBehaviour
{
    private float defaultSize;

    [SerializeField] private Sprite shrinkSprite;
    [SerializeField] private Sprite expandSprite;
    [SerializeField] private float ExpandSize;
    [SerializeField] private float ExpandSpeed;
    [SerializeField] private float ShrinkSpeed;
    [SerializeField] private float HoldTime;


    private void Start()
    {
        defaultSize = transform.localScale.x;
        StartCoroutine(Expand());
    }


    IEnumerator Expand()
    {
        yield return new WaitForSecondsRealtime(HoldTime);


        while (transform.localScale.x != ExpandSize)
        {
            transform.localScale = Vector2.MoveTowards(transform.localScale, Vector2.one * ExpandSize, ExpandSpeed);
            yield return null;
        }


        GetComponent<SpriteRenderer>().sprite = expandSprite;

        StartCoroutine(Shrink());
    }


    IEnumerator Shrink()
    {
        yield return new WaitForSecondsRealtime(HoldTime);


        while (transform.localScale.x != defaultSize)
        {
            transform.localScale = Vector2.MoveTowards(transform.localScale, Vector2.one * defaultSize, ShrinkSpeed);
            yield return null;
        }


        GetComponent<SpriteRenderer>().sprite = shrinkSprite;

        StartCoroutine(Expand());
    }
}
