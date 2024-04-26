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
    public bool aguapronto = false;

    public void SpawnObject1()
    {
        Instantiate(objectToSpawn1, objectSpawner.transform.position, objectSpawner.transform.rotation);
        if(cebolapronto == true) 
        {
            alhoUi.SetActive(false);
            corteUi.SetActive(true);
            alhopronto = true;

        }
        
    }
    public void SpawnObject2()
    {
        Instantiate(objectToSpawn2, objectSpawner.transform.position, objectSpawner.transform.rotation);
        cebolaUi.SetActive(false);
        corteUi.SetActive(true);
        cebolapronto = true;
    }
    public void SpawnObject3()
    {
        Instantiate(objectToSpawn3, objectSpawner.transform.position, objectSpawner.transform.rotation);
        
        if (aguapronto == true)
        {
            aguaUi.SetActive(false);
            panelaUi.SetActive(true);
           

        }
    }
    public void SpawnObject4()
    {
        Instantiate(objectToSpawn4, objectSpawner.transform.position, objectSpawner.transform.rotation);
        

        if (alhopronto == true)
        {
            arrozUi.SetActive(false);
            panelaUi.SetActive(true);
            aguapronto = true;


        }
    }
}
