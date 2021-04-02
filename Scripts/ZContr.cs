using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZContr : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform dest;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(dest.position);
    }
}
