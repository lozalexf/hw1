using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMine : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) { GameObject mine = Instantiate(prefab, transform.position + transform.forward, Quaternion.identity); }
    }
}
