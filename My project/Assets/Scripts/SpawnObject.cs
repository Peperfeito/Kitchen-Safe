using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject objectToSpawn1;
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn3;
    public GameObject objectToSpawn4;
    public GameObject objectSpawner;

    public GameObject cebolaUi;
    public GameObject alhoUi;
    public GameObject arrozUi;
    public GameObject aguaUi;
    public GameObject corteUi;
    public GameObject panelaUi;
    public GameObject fritarUi;

    

    public bool cebolapronto = false;
    public bool alhopronto = false;
    public bool arrozpronto = false;
    public bool aguapronto = false;
    public bool cebolaPanela = false;
    public bool alhoPanela = false;
    public bool arrozPanela = false;
    public bool aguaPanela = false;
    public bool alhocorte = false;
    public bool cebolacorte = false;
    public bool cebolaordem = false;
    public bool alhoordem = false;
    public bool aguaordem = false;
    public bool arrozordem = false;



    public void Start()
    {
        
       
    }

    public void SpawnObject1()
    {
        Instantiate(objectToSpawn1, objectSpawner.transform.position, objectSpawner.transform.rotation);
        if(cebolaordem == true) 
        {
            if (alhopronto == false)
            {
                alhoUi.SetActive(false);
                corteUi.SetActive(true);
                alhopronto = true;
            }

        }
        
    }
    public void SpawnObject2()
    {
        Instantiate(objectToSpawn2, objectSpawner.transform.position, objectSpawner.transform.rotation);
        if (cebolapronto == false)
        {
            cebolaUi.SetActive(false);
            corteUi.SetActive(true);
            cebolapronto = true;
        }
    }
    public void SpawnObject3()
    {
        Instantiate(objectToSpawn3, objectSpawner.transform.position, objectSpawner.transform.rotation);
        
        if (alhoordem == true)
        {
            if (arrozpronto == false)
            {
                arrozUi.SetActive(false);
                panelaUi.SetActive(true);
                arrozpronto = true;
            }



        }
    }
    public void SpawnObject4()
    {
        Instantiate(objectToSpawn4, objectSpawner.transform.position, objectSpawner.transform.rotation);
        

        if (arrozordem == true)
        {
            if (aguapronto == false)
            {
                aguaUi.SetActive(false);
                panelaUi.SetActive(true);
                aguapronto = true;
            }


        }
    }
}
