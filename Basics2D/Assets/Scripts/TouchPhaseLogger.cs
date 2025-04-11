using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPhaseLogger : MonoBehaviour
{    
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("Dokunma Baþladý: " + touch.position);
                    break;
                case TouchPhase.Moved:
                    Debug.Log("Dokunma hareket etti: " + touch.position);
                    break;
                case TouchPhase.Stationary:
                    Debug.Log("Dokunma Sabit: " + touch.position);
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Dokunma Sona Erdi: " + touch.position);
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("Dokunma iptal edildi: " + touch.position);
                    break;
            }

            float screenWidth = Screen.width;
            float screenHeight = Screen.height;
            /*
            if(touch.position.x < screenWidth / 2)
            {
                Debug.Log("Dokunma ekranýn sol tarafýnda");
            }
            else
            {
                Debug.Log("Dokunma ekranýn sað tarafýnda");
            }

            if(touch.position.y < screenHeight / 2)
            {
                Debug.Log("Dokunma ekranýn alt tarafýnda");
            }
            else
            {
                Debug.Log("Dokunma ekranýn sað tarafýnda");
            }
            */
            if (touch.position.x < screenWidth / 2 && touch.position.y >= screenHeight / 2)
            {
                Debug.Log("Dokunma ekranýn sol üst tarafýnda");
            }
            else if(touch.position.x >= screenWidth / 2 && touch.position.y >= screenHeight / 2)
            {
                Debug.Log("Dokunma ekranýn sað üst tarafýnda");
            }

            else if (touch.position.x < screenWidth / 2 && touch.position.y < screenHeight / 2)
            {
                Debug.Log("Dokunma ekranýn sol alt tarafýnda");
            }
            else if(touch.position.x >= screenWidth / 2 && touch.position.y < screenHeight / 2)
            {
                Debug.Log("Dokunma ekranýn sað alt tarafýnda");
            }
        }
    }
}
