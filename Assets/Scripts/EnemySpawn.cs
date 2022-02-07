using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    Transform[] spawners;
    [SerializeField]
    GameObject prefab;
    int cooldown = 0;
    public int countOfEnemy = 0;
    [SerializeField]
    int maxEnemy = 20;
    void Update()
    {
        if (countOfEnemy < maxEnemy)
        {
            if (cooldown == 0)
            {
                Instantiate(prefab, spawners[Random.Range(0, 10)].position, Quaternion.identity);
                countOfEnemy++;
            }
            if (cooldown == 1500)
            {
                Instantiate(prefab, spawners[Random.Range(0, 10)].position, Quaternion.identity);
                countOfEnemy++;
                cooldown = -1;
            }
            cooldown++;
        }
    }
}