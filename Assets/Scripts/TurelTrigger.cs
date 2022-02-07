using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurelTrigger : MonoBehaviour
{
    float playerPos;
    Vector3 dir;
    [SerializeField] float speed;
    [SerializeField] GameObject bullet;
    int frameCount;
    int maxFrame = 1500;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dir = other.transform.position - transform.forward;
            dir.Normalize();
            //if (frameCount => maxFrame)
            {
                var b = Instantiate(bullet, transform.position, Quaternion.identity);
                b.transform.Translate(dir * speed * Time.deltaTime);
            }
        }
    }
    void Start()
    {
        frameCount = 0;
    }
    void Update()
    {
        frameCount++;
    }
}
