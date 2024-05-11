using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaldiranAISaldrilari : MonoBehaviour
{
    public GameObject BiteAttack;
    public GameObject RoarAttack;
    public GameObject StingerAttack;
    public SaldiranAISaldirabilir saldirabilir;
    public Animator anim;

    void Start()
    {
    
    }

    void Update()
    {
        if(saldirabilir.saldir == true)
        {
            int saldiriInt = Random.Range(0, 3);
            if(saldiriInt==0 )
            {
                anim.SetTrigger("Bite");
                StartCoroutine(SaldiriTipi(BiteAttack));
            }
            else if(saldiriInt==1 )
            {
                anim.SetTrigger("Roar");
                StartCoroutine(SaldiriTipi(RoarAttack));
            }
            else
            {
                anim.SetTrigger("Stinger");
                StartCoroutine(SaldiriTipi(StingerAttack));
            }
        }
    }

    IEnumerator SaldiriTipi(GameObject saldiriTuru)
    {
        saldiriTuru.SetActive(true);
        saldirabilir.saldir = false;
        yield return new WaitForSeconds(.5f);
        saldiriTuru.SetActive(false);
    }
}
