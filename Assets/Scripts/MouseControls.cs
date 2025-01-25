using UnityEngine;

public class MouseControls : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameManager.gameManager.GameStart();


            if (transform.position.x < -2.8f || transform.position.x > 2.8f || transform.position.y < -4.9f || transform.position.y > 4.9f)
            {
                GameManager.gameManager.GameOver();
            }

            else
            {
                transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            }
        }


        else if (Input.GetMouseButtonUp(0))
        {
            GameManager.gameManager.GameOver();
        }

    }
}
