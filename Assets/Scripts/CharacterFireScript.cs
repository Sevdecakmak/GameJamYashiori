using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFireScript : MonoBehaviour
{
    public GameObject bullet;
    GameObject klon;
    public float sikmaAraligi;
    bool fire;

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        if(Physics.Raycast(transform.position, forward, out hit, Mathf.Infinity))
        {
            if(fire == true && Input.GetMouseButton(0))
            {
                fire = false; 
                klon = Instantiate(bullet, transform.position, transform.rotation);
                klon.GetComponent<Rigidbody>().AddForce(klon.transform.forward * 1000);
                StartCoroutine(FireTime());
            }
        }
    }
    IEnumerator FireTime()
    {
        yield return new WaitForSeconds(sikmaAraligi);
        fire = true;
    }
}
