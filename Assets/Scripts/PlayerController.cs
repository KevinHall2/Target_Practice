using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Transform cameraHolder;

    [SerializeField]
    float mouseSensitivity = 1;

    float verticalLookRotation;

    //Hides the mouse cursor and locks the mouse to stay within bounds of the game screen
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Handles mouse drag input to rotate the camera up, down, left, and right
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity);
        verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity;

        //Clamps the rotation view to keep the player from looking out of bounds
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, 0, 0);
    }
}
