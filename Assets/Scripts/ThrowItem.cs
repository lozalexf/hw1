using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItem : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    int force;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            var go = Instantiate(prefab, transform.position + transform.forward, Quaternion.identity);
            go.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        }
    }
}
