using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    public GameObject alhoUi;
    public GameObject panelaUi;
    public GameObject arrozUi;
    public GameObject aguaUi;
    public GameObject prontoUi;
    public GameObject pratodearroz;
    
    public bool cebolapronto = false;
    public bool alhopronto = false;
    public bool arrozpronto = false;
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cebola"))
        {
            panelaUi.SetActive(false);
            alhoUi.SetActive(true);
            cebolapronto = true;

        }

        if (collision.gameObject.CompareTag("Alho"))
        {
            

            if (cebolapronto == true)
            {
                panelaUi.SetActive(false);
                arrozUi.SetActive(true);
                alhopronto = true;
            }
        }

        if (collision.gameObject.CompareTag("Arroz"))
        {
            
            if (alhopronto == true)
            {
                Destroy(collision.gameObject);
                panelaUi.SetActive(false);
                aguaUi.SetActive(true);
                arrozpronto = true;
            }

        }

        if (collision.gameObject.CompareTag("Agua"))
        {
            

            if (arrozpronto == true)
            {
                Destroy(collision.gameObject);
                panelaUi.SetActive(false);
                prontoUi.SetActive(true);
                pratodearroz.SetActive(true);
                Destroy(this.gameObject);

            }

        }

    }
}
