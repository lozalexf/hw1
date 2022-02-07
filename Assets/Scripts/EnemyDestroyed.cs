/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyed : MonoBehaviour
{
    public Action<EnemyDestroyed> OnDestroyed;
    void Update()
    {
        StartCoroutine(Destroy());
    }
    private void Destroy()
    {
        while (true)
        {
            OnDestroyed.Invoke();
            yield return new WaitForSeconds(5);
        }
    }
}*/
