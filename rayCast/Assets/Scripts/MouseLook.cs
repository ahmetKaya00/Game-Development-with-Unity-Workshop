using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float mouseSensivity = 100f;
    [SerializeField] Transform playerBody;
    [SerializeField] Joystick lookJoystick;

    float xRotate = 0f;

    private void Update()
    {
        float mouseX = lookJoystick.Horizontal * mouseSensivity * Time.deltaTime;

        float mouseY = lookJoystick.Vertical * mouseSensivity * Time.deltaTime;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
