using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float mousex;
    private float mousey;
    [SerializeField]
    private float mouseSens;
    public Transform player;

    public float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mousex = Input.GetAxis("Mouse X") * mouseSens;
        mousey = Input.GetAxis("Mouse Y") * mouseSens;

        xRotation -= mousey;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        player.Rotate(Vector3.up * mousex);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
