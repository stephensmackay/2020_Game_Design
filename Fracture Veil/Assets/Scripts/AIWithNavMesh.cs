using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIWithNavMesh : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;

    public Transform destination;

    private void Start()
    {
        destination = transform;
        agent = GetComponent<NavMeshAgent>();
    }
}


