using UnityEngine;

public class TouchControls : MonoBehaviour
{
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            transform.position = new Vector2(Camera.main.ScreenToWorldPoint(touch.position).x, Camera.main.ScreenToWorldPoint(touch.position).y);


            switch (touch.phase)
            {
                case TouchPhase.Began:
                    {
                        GameManager.gameManager.GameStart();
                            break;
                    }

                case TouchPhase.Ended:
                    {
                        GameManager.gameManager.GameOver();
                        break;
                    }
            }
        }
    }
}
