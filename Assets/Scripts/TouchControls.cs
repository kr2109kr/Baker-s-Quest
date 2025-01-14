using UnityEngine;

public class TouchControls : MonoBehaviour
{
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            transform.position = Camera.main.ScreenToWorldPoint(touch.position);
        }
    }
}
