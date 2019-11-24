using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public PlayerShooter PlayerShooter;
    public Camera mainCamera;

    private void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.touches[i];
            Ray touchRay = mainCamera.ScreenPointToRay(touch.position);
            RaycastHit[] hits = Physics.RaycastAll(touchRay);
            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.CompareTag("ShootButton"))
                {
                    PlayerShooter.Shooting = true;
                    if (Input.touches[i].phase == TouchPhase.Ended)
                    {
                        PlayerShooter.Shooting = false;
                    }
                }
            }
        }
    }

        /*
    private void OnMouseDown()
    {
        PlayerShooter.Shooting = true;
    }

    private void OnMouseUp()
    {
        PlayerShooter.Shooting = false;
    }
    */
}
