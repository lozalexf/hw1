using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyVision : MonoBehaviour
{
    public Action<Vector3> PlayerInVision;
    public Action<Vector3> PlayerOutVision;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInVision?.Invoke(other.transform.position);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        CancelInvoke();
        GetComponent<EnemyPatrol>().isHunting = false;
    }
}
