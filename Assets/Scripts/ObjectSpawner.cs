using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectSpawner : MonoBehaviour
{
    public UnityAction objectDestroyed;

    [SerializeField]
    Transform[] spawners;
    [SerializeField]
    GameObject prefab;
    float cooldown = 0;
    public int countOfObjects = 0;
    [SerializeField]
    int maxObjects = 20;
    void Start()
    {
        objectDestroyed += OnObjectDestroyed;
    }
    void Update()
    {
        if (countOfObjects < maxObjects)
        {
            if (cooldown == 0)
            {
                Instantiate(prefab, spawners[Random.Range(0, 10)].position, Quaternion.identity);
                countOfObjects++;
            }
            if (cooldown == 5)
            {
                Instantiate(prefab, spawners[Random.Range(0, 10)].position, Quaternion.identity);
                countOfObjects++;
                cooldown = -1;
            }
            cooldown += Time.deltaTime;
        }
    }
    void OnObjectDestroyed()
    {
        countOfObjects--;
    }
}