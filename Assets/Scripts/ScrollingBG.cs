using UnityEngine;
using UnityEngine.UI;

public class ScrollingBG : MonoBehaviour
{
    private Material material;
    private float distance;
    [SerializeField] private float moveSpeed;


    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }


    private void Update()
    {
        distance += Time.deltaTime * 2f;
        material.mainTextureOffset += Vector2.up * moveSpeed * GameManager.gameManager.gameSpeed;
    }
}
