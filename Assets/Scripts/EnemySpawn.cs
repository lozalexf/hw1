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
    int countOfEnemy = 0;
    [SerializeField]
    int maxEnemy = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (countOfEnemy < maxEnemy)
        {
            if (cooldown == 0)
            {
                Instantiate(prefab, spawners[Random.Range(0, 10)].position, Quaternion.identity);
                countOfEnemy++;
                Debug.Log("cooldown = 0");
            }
            if (cooldown == 500)
            {
                Instantiate(prefab, spawners[Random.Range(0, 10)].position, Quaternion.identity);
                countOfEnemy++;
                cooldown = -1;
                Debug.Log("cooldown = 500");
            }
            cooldown++;
        }
    }
}