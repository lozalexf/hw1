using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    [SerializeField]
    private int speed = 10;
    [SerializeField]
    private int force = 20;
    private bool groundCheck = false;
    private Rigidbody player;
    [SerializeField]
    private CharacterController controller;
    
    // Start is called before the first frame update

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    void OnCollisionStay(Collision collision)
    {
        groundCheck = true;
    }

    void OnCollisionExit(Collision collision)
    {
        groundCheck = false;
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (groundCheck && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("прыжок");
            player.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
