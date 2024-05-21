using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float lerpValue;

    private Vector3 offset;

    private Vector3 newPosition;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        SmoothCameraFollow();
    }

    private void SmoothCameraFollow()
    {
        newPosition = Vector3.Lerp(transform.position, target.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }

}
