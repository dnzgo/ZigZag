using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{
    [SerializeField] private PlayerInputController playerInput;

    public Vector3 GetDirection()
    {
        return playerInput.playerDirection;
    }

}
