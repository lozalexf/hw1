using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurelTrigger : MonoBehaviour
{
    float playerPos;
    Vector3 dir;
    [SerializeField] float speed;
    [SerializeField] GameObject bullet;
    float frameCount;
    float maxSecond = 5;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dir = other.transform.position - transform.forward;
            dir.Normalize();
            if (frameCount >= maxSecond)
            {
                var b = Instantiate(bullet, transform.position, Quaternion.identity);
                //while (b.GetComponent<BulletScript>().isDestroy)
                {
                    Debug.Log("sdsds");
                    b.transform.Translate(dir * speed * Time.deltaTime);
                }
            }
        }
    }
    void Start()
    {
        frameCount = 0;
    }
    void Update()
    {
        frameCount += Time.deltaTime;
    }
}
