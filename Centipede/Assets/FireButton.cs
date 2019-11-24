using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public PlayerShooter PlayerShooter;

    private void OnMouseDown()
    {
        PlayerShooter.Shooting = true;
    }

    private void OnMouseUp()
    {
        PlayerShooter.Shooting = false;
    }
}
