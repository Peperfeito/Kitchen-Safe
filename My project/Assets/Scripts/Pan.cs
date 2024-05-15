using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    public GameObject alhoUi;
    public GameObject panelaUi;
    public GameObject aguaUi;
    public GameObject prontoUi;
    public GameObject arrozUi;
    public GameObject pratodearroz;
    private SpawnObject spawnObject;

    
    public bool arrozpronto = false;
    public bool cebolapronto = false;
    public bool alhopronto = false;
    public bool aguapronto = false;


    private void Update()
    {
        if ((arrozpronto == true) && (cebolapronto == true) && (alhopronto == true) && (aguapronto == true))
        {
            prontoUi.SetActive(true);
            pratodearroz.SetActive(true);


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CebolaCortada"))
        {
            if (cebolapronto == false)
            {
                panelaUi.SetActive(false);
                alhoUi.SetActive(true);
                cebolapronto = true;
            }

        }

        if (collision.gameObject.CompareTag("AlhoCortado"))
        {
            if (alhopronto == false)
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
                if (arrozpronto == false)
                {
                    Destroy(collision.gameObject);
                    panelaUi.SetActive(false);
                    aguaUi.SetActive(true);
                    arrozpronto = true;
                }
            }

        }

        if (collision.gameObject.CompareTag("Agua"))
        {


            if (arrozpronto == true)
            {
                if (aguapronto == false)
                {
                    Destroy(collision.gameObject);
                    aguaUi.SetActive(false);
                    panelaUi.SetActive(false);
                    prontoUi.SetActive(true);
                    pratodearroz.SetActive(true);

                    aguapronto = true;
                    Destroy(this.gameObject);
                }

            }

        }

    }
}
