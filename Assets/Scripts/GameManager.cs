using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }


    private float score;


    [SerializeField] private Text scoreText;
    private float gameSpeed;


    private void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }

        else
        {
            gameManager = this;
        }
    }


    private void Update()
    {

        score += Time.deltaTime * gameSpeed;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }


    public void GameStart()
    {
        gameSpeed = 1;
    }


    public void GameOver()
    {
        gameSpeed = 0;
        
    }
}
