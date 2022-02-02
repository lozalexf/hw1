using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float mousex;
    private float mousey;
    [SerializeField]
    private float mouseSens;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mousex = Input.GetAxis("Mouse X") * mouseSens;
        mousey = Input.GetAxis("Mouse Y") * mouseSens;

        player.Rotate(mousex * new Vector3(0, 1, 0));
        transform.Rotate(-mousey * new Vector3(1, 0, 0));
    }
}
