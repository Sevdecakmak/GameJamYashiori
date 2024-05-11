using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaldiranAISaldirabilir : MonoBehaviour
{
    public bool saldir;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            saldir = true;
        }
    }
}
