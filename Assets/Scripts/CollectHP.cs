using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHP : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<PlayerHealth>().health <= 60)
            {
                other.GetComponent<PlayerHealth>().health += 30;
                Destroy(gameObject);
                GetComponent<ObjectSpawner>().objectDestroyed.Invoke();
            }
        }
    }
}
