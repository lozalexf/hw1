using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItem : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    int force;
    Rigidbody item;
    Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        item = prefab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = transform.position;
        playerPosition.z++;
        if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(prefab, playerPosition, Quaternion.identity);
            item.AddForce(Vector3.forward * force, ForceMode.Impulse);
        }
    }
}
