using UnityEngine;
using UnityEngine.UI;

public class ScrollingBG : MonoBehaviour
{
    private Material material;
    private float distance;


    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }


    private void Update()
    {
        distance += Time.deltaTime * 2f;
        material.mainTextureOffset += Vector2.up * 0.0001f;
    }
}
