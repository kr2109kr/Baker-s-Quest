using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int hitPoints = 3;
    [SerializeField] private Text HPText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            TakeDamage();
        }

        if (collision.CompareTag("Coin"))
        {
            GameManager.gameManager.AddCoin();
            Destroy(collision.gameObject);
        }
    }


    public void TakeDamage()
    {
        hitPoints -= 1;
        HPText.text = hitPoints.ToString();

        if (hitPoints == 0)
        {
            GameManager.gameManager.GameOver();
        }
    }
}
