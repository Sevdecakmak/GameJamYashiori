using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class SaldiranAI : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject hedef;
    public float health;
    public Slider healthSlider;
    

    void Start()
    {
        agent= GetComponent<NavMeshAgent>();
        healthSlider.maxValue = health;
        healthSlider.minValue = 0;
        healthSlider.value = health;
        hedef = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        agent.destination = hedef.transform.position;
    }
}
