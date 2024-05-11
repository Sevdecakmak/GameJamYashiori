using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilahScript : MonoBehaviour
{
    GameObject Donme;
    private void Start()
    {
        Donme = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Update()
    {
        transform.rotation = Donme.transform.rotation;
    }
}
