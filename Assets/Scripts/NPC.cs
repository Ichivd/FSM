using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class NPC : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform destination;
    
    void MoveTo(Vector3 point)
    {
        agent.SetDestination(point);
    }
    void Update()
    {
        MoveTo (destination.position);
    }
}
