using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomMine : MonoBehaviour
{
    bool touch;
    private Vector3 dir;
    float force = 1500;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            touch = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (touch)
        {
            dir = other.transform.position - transform.position;
            other.GetComponent<Rigidbody>().AddForce(dir.normalized * force, ForceMode.Impulse);
            touch = false;
        }
    }
    void Start()
    {
        touch = false;
    }
}
