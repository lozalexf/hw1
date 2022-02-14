using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] PlayerInventory.Keys key;
    private void OnTriggerEnter(Collider other) { if (other.CompareTag("Player") && other.GetComponent<PlayerInventory>().HasKey(key)) transform.Translate(Vector3.up * 4); }

}
