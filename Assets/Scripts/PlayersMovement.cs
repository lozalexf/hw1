using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    [SerializeField]
    private int speed = 10;
    [SerializeField]
    private int force = 20;
    [SerializeField]
    private int shift = 20;
    private bool groundCheck;
    private Rigidbody player;
    
    // Start is called before the first frame update

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    void OnCollisionStay(Collision collision)
    {
        groundCheck = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        groundCheck = false;
    }

    void Update()
    {
        GetInput();
    }
    void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.forward * shift * Time.deltaTime;
            }
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }


        if (groundCheck && Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
