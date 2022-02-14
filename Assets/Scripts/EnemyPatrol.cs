using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] Transform[] PatrolPoints;
    int index;
    NavMeshAgent agent;
    public bool isHunting;
    void Start()
    {
        isHunting = false;
        index = 0;
        agent = GetComponent<NavMeshAgent>();
        GetComponent<EnemyVision>().PlayerInVision += OnPlayerVision;
    }
    void Update()
    {
        if (!agent.pathPending && !isHunting && agent.remainingDistance <= .5f && PatrolPoints.Length!=0)
        {
            SetPatrolPoint();
        }
    }
    void SetPatrolPoint()
    {
        if (index == PatrolPoints.Length) index = 0;
        isHunting = false;
        Vector3 dest = PatrolPoints[index].position;
        agent.destination = dest;
        index++;
    }
    void OnPlayerVision(Vector3 player)
    {
        agent.destination = player;
        isHunting = true;
    }
}
