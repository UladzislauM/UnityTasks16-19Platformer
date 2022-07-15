using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent (typeof(Shooter))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooter shooter;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        shooter = GetComponent<Shooter>();
    }

    private void Update()
    {
        float horisontalDirection = Input.GetAxis(GlobalStringVaribals.HorisontalAxis);
        bool isjampButton = Input.GetButtonDown(GlobalStringVaribals.JumpBatton);

        if (Input.GetButtonDown(GlobalStringVaribals.Fire_1))
        {
            shooter.Shoot(horisontalDirection);
        }

        playerMovement.Move(horisontalDirection, isjampButton);
    }
}
