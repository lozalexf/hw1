using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyZoneScript : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            door.transform.Translate(Vector3.up * 4);
            Destroy(gameObject);
        }
    }
}
