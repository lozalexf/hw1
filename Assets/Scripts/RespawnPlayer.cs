using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    private Vector3 respawn = new Vector3(0, 2, 0);
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = respawn;
    }
}
