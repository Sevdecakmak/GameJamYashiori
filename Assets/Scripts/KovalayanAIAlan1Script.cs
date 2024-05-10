using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KovalayanAIAlan1Script : MonoBehaviour
{
    AudioSource YaratikSesi;
    void Start()
    {
        YaratikSesi = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            YaratikSesi.Play();
        }
    }
}
