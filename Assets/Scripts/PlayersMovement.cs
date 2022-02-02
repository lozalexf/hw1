using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    [SerializeField]
    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ad = Input.GetAxis("Horizontal");
        var ws = Input.GetAxis("Vertical");

        var move = new Vector3(ad, 0, ws);

        transform.position += move * Time.deltaTime * speed;
    }
}
