using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private Text scoreText;


    private void Start()
    {
        scoreText.text = Mathf.FloorToInt(GameManager.gameManager.GetScore()).ToString();
    }


    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }


    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }


}
