using UnityEngine;
using System.Collections.Generic;

public class BackgroundChanger : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    [SerializeField] private List<Material> materials;


    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }


    private void Update()
    {
        int score = Mathf.FloorToInt(GameManager.gameManager.score);


        if (score == 31) { meshRenderer.material = materials[0]; }


        else if (score == 61) { meshRenderer.material = materials[2]; }


        else if (score == 91) { meshRenderer.material = materials[3]; }


        else if (score == 121) { meshRenderer.material = materials[4]; }


        else if (score == 151) { meshRenderer.material = materials[5]; }


        else if (score == 181) { meshRenderer.material = materials[6]; }


        else if (score == 211) { meshRenderer.material = materials[7]; }


        else if (score == 241) { meshRenderer.material = materials[8]; }
    }
}
