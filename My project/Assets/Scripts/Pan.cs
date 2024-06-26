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

    




    private void Start()
    {
        spawnObject = GameObject.Find("SpawnerManager").GetComponent<SpawnObject>();
        

    }
    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CebolaCortada"))
        {
            Destroy(collision.gameObject);
            if (spawnObject.cebolacorte == true)
            {
                if (!spawnObject.cebolaPanela)
                {
                    panelaUi.SetActive(false);
                    alhoUi.SetActive(true);
                    spawnObject.cebolaPanela = true;
                    spawnObject.cebolaordem = true;
                }
            }

            if(spawnObject.cebolaPanela == true)
            {
                if (spawnObject.alhoPanela == true)
                {
                    if (spawnObject.arrozPanela == true)
                    {
                        if (spawnObject.aguaPanela == true)
                        {
                            aguaUi.SetActive(false);
                            panelaUi.SetActive(false);
                            prontoUi.SetActive(true);
                            pratodearroz.SetActive(true);
                            alhoUi.SetActive(false);


                            Destroy(this.gameObject);
                        }
                    }
                }
            }

        }

        if (collision.gameObject.CompareTag("AlhoCortado"))
        {
            Destroy(collision.gameObject);
            spawnObject.alhoPanela = true;
            if (spawnObject.alhocorte == true)
            {
                if (spawnObject.alhoordem == false)
                {
                    panelaUi.SetActive(false);
                    arrozUi.SetActive(true);
                    spawnObject.alhoordem = true;
                }
            }

            if (spawnObject.cebolaPanela == true)
            {
                if (spawnObject.alhoPanela == true)
                {
                    if (spawnObject.arrozPanela == true)
                    {
                        if (spawnObject.aguaPanela == true)
                        {
                            aguaUi.SetActive(false);
                            panelaUi.SetActive(false);
                            prontoUi.SetActive(true);
                            pratodearroz.SetActive(true);
                            alhoUi.SetActive(false);


                            Destroy(this.gameObject);
                        }
                    }
                }
            }
        }

        if (collision.gameObject.CompareTag("Arroz"))
        {
            Destroy(collision.gameObject);
            spawnObject.arrozPanela = true;
            if (spawnObject.arrozpronto == true)
            {
                if (spawnObject.arrozordem == false)
                {
                    
                    panelaUi.SetActive(false);
                    aguaUi.SetActive(true);
                    spawnObject.arrozordem = true; 


                }
            }

            if (spawnObject.cebolaPanela == true)
            {
                if (spawnObject.alhoPanela == true)
                {
                    if (spawnObject.arrozPanela == true)
                    {
                        if (spawnObject.aguaPanela == true)
                        {
                            aguaUi.SetActive(false);
                            panelaUi.SetActive(false);
                            prontoUi.SetActive(true);
                            pratodearroz.SetActive(true);
                            alhoUi.SetActive(false);


                            Destroy(this.gameObject);
                        }
                    }
                }
            }

        }

        if (collision.gameObject.CompareTag("Agua"))
        {
            Destroy(collision.gameObject);
            spawnObject.aguaPanela = true;

            if (spawnObject.aguapronto == true)
            {
                if (spawnObject.aguaordem == false)
                {
                    
                    aguaUi.SetActive(false);
                    panelaUi.SetActive(false);
                    prontoUi.SetActive(true);
                    pratodearroz.SetActive(true);

                   
                    Destroy(this.gameObject);
                }

            }

        }

        if (spawnObject.cebolaPanela == true)
        {
            if (spawnObject.alhoPanela == true)
            {
                if (spawnObject.arrozPanela == true)
                {
                    if (spawnObject.aguaPanela == true)
                    {
                        aguaUi.SetActive(false);
                        panelaUi.SetActive(false);
                        prontoUi.SetActive(true);
                        pratodearroz.SetActive(true);
                        alhoUi.SetActive(false);


                        Destroy(this.gameObject);
                    }
                }
            }
        }

    }
}
