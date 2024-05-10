using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KovalayanAIScript : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject hedef;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = hedef.transform.position;
    }
}
