using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [HideInInspector] public Vector3 playerDirection;

    private void Start()
    {
        playerDirection = Vector3.left;

    }

    private void Update()
    {
        HandleInputs();
    }

    private void HandleInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        if (playerDirection.x == -1)
        {
            playerDirection = Vector3.forward;
        }
        else
        {
            playerDirection = Vector3.left;
        }
    }

}
