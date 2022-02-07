using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomMine : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
