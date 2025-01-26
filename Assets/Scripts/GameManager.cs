using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }

    public float score { get; private set; }
    private float coin;

    [SerializeField] private Text scoreText;
    [SerializeField] private Text coinText;
    
    private float highScore;
    public float gameSpeed = 0;


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


    private void Start()
    {
        Time.timeScale = 0;
    }


    private void Update()
    {
        score += Time.deltaTime * gameSpeed;
        scoreText.text = Mathf.FloorToInt(score).ToString();
        coinText.text = coin.ToString();
    }


    public void GameStart()
    {
        Time.timeScale = 1;
        gameSpeed = 1;
    }


    public void GameOver()
    {
        SceneManager.LoadScene("Game Over Menu");
    }


    public void AddCoin()
    {
        coin++;
    }

    public float GetScore()
    {
        return score;
    }
}
