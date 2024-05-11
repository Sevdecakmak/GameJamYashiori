using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaldiranAIHasarAl : MonoBehaviour
{
    public Slider healthBar;
    public float alinanHasar;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            healthBar.value -= alinanHasar;
        }
    }
}
