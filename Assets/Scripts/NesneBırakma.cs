using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NesneBırakma : MonoBehaviour
{
    public bool isCantaAlindi;
    public GameObject parlayanCubuk;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (isCantaAlindi == true && Input.GetKeyUp(KeyCode.Q))
        {
            Instantiate(parlayanCubuk, new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z + 0.5f),Quaternion.identity);
        } 
    }
}
