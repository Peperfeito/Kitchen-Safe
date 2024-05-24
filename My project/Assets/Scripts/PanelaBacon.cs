using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelaBacon : MonoBehaviour
{
    public GameObject alhoUi;
    public GameObject panelaUi;
    public GameObject aguaUi;
    public GameObject prontoUi;
    public GameObject arrozUi;
    public GameObject corteUi;
    [SerializeField] GameObject baconUi;
    public GameObject pratodearroz;
    private SpawnObject spawnObject;

    [SerializeField] GameObject objetivoUI;
    [SerializeField] GameObject parabensUI;



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

            if (spawnObject.cebolaPanela == true)
            {
                if (spawnObject.alhoPanela == true)
                {
                    if (spawnObject.arrozPanela == true)
                    {
                        if (spawnObject.aguaPanela == true)
                        {
                            if (spawnObject.baconPanela == true)
                            {
                                aguaUi.SetActive(false);
                                panelaUi.SetActive(false);
                                prontoUi.SetActive(true);
                                pratodearroz.SetActive(true);
                                alhoUi.SetActive(false);
                                arrozUi.SetActive(false);
                                corteUi.SetActive(false);
                                objetivoUI.SetActive(false);
                                parabensUI.SetActive(true);

                                Destroy(this.gameObject);
                            }
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
                            if (spawnObject.baconPanela == true)
                            {
                                aguaUi.SetActive(false);
                                panelaUi.SetActive(false);
                                prontoUi.SetActive(true);
                                pratodearroz.SetActive(true);
                                alhoUi.SetActive(false);
                                objetivoUI.SetActive(false);
                                parabensUI.SetActive(true);


                                Destroy(this.gameObject);
                            }
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
                            if (spawnObject.baconPanela == true)
                            {
                                aguaUi.SetActive(false);
                                panelaUi.SetActive(false);
                                prontoUi.SetActive(true);
                                pratodearroz.SetActive(true);
                                alhoUi.SetActive(false);
                                objetivoUI.SetActive(false);
                                parabensUI.SetActive(true);


                                Destroy(this.gameObject);
                            }
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

                    baconUi.SetActive(true);
                    panelaUi.SetActive(false);
                    spawnObject.aguaordem = true;


                    
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
                            if (spawnObject.baconPanela == true)
                            {
                                aguaUi.SetActive(false);
                                panelaUi.SetActive(false);
                                prontoUi.SetActive(true);
                                pratodearroz.SetActive(true);
                                alhoUi.SetActive(false);
                                objetivoUI.SetActive(false);
                                parabensUI.SetActive(true);


                                Destroy(this.gameObject);
                            }
                        }
                    }
                }
            }

        }

        if (collision.gameObject.CompareTag("Bacon"))
        {
            Destroy(collision.gameObject);
            spawnObject.baconPanela = true;

            if (spawnObject.baconpronto == true)
            {
                if (spawnObject.baconordem == false)
                {

                    baconUi.SetActive(false);
                    panelaUi.SetActive(false);
                    prontoUi.SetActive(true);
                    pratodearroz.SetActive(true);


                    Destroy(this.gameObject);
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
                            if (spawnObject.baconPanela == true)
                            {
                                aguaUi.SetActive(false);
                                panelaUi.SetActive(false);
                                prontoUi.SetActive(true);
                                pratodearroz.SetActive(true);
                                alhoUi.SetActive(false);
                                objetivoUI.SetActive(false);
                                parabensUI.SetActive(true);
                            }


                            Destroy(this.gameObject);
                        }
                    }
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
                        if (spawnObject.baconPanela == true)
                        {
                            aguaUi.SetActive(false);
                            panelaUi.SetActive(false);
                            prontoUi.SetActive(true);
                            pratodearroz.SetActive(true);
                            alhoUi.SetActive(false);
                            objetivoUI.SetActive(false);
                            parabensUI.SetActive(true);


                            Destroy(this.gameObject);
                        }
                    }
                }
            }
        }

    }
}
