using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchField : MonoBehaviour
{
    [Header("Mouse Settings:")]
    [Range(50f, 1000f)] public float mouseSensitivity = 100f;
    [Header("Mouse Components:")]
    public Camera mainCamera;
    public Transform playerBody;

    private float xRotation = 0f;

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("touch");
            MouseMovement();
        }
    }

    private void MouseMovement()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        mainCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
