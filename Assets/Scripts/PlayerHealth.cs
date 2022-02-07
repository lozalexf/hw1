using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    private void Start()
    {
        health = 100;
    }
    void TakeDamage(int damage)
    {
        health -= damage;
    }
}
