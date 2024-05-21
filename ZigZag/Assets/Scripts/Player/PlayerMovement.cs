using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter dataTransmitter;
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        SetPlayerMovement();
    }

    private void SetPlayerMovement()
    {
        transform.position += dataTransmitter.GetDirection() * moveSpeed * Time.deltaTime;
    }

}
