using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMove : MonoBehaviour
{
    Camera kamera;
    Vector3 screenPoint;
    Vector3 offset;

    Vector3 baslangic_pozisyonu;
    GameObject[] kutu_dizisi;

    GameObject dogruNokta;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;
        transform.position = currentPosition;
    }

    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangic_pozisyonu = transform.position;
        kutu_dizisi = GameObject.FindGameObjectsWithTag("Box");
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dogruNokta = null;
            foreach (GameObject Box in kutu_dizisi)
            {
                if (Box.name == gameObject.name)
                {
                    float mesafe = Vector3.Distance(Box.transform.position, transform.position);

                    if (mesafe <= 1)
                    {
                        dogruNokta = Box;
                        break;
                    }
                }
            }

            if (dogruNokta != null)
            {
                transform.position = dogruNokta.transform.position;
            }
            else
            {
                transform.position = baslangic_pozisyonu;
            }
        }
    }
}
