using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    Vector3 mousePositionOffset;

    public GameObject objectToSpawn1;
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn3;
    public GameObject objectToSpawn4;
    public GameObject objectToSpawn5;
    public GameObject objectSpawner;

    public GameObject cebolaUi;
    public GameObject alhoUi;
    public GameObject arrozUi;
    public GameObject aguaUi;
    public GameObject corteUi;
    public GameObject panelaUi;
    public GameObject fritarUi;
    public GameObject baconUi;



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
    public bool baconpronto = false;
    public bool baconordem = false;
    public bool baconPanela = false;


    private Vector3 GetMouseWordPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

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



    public void SpawnObject1OnMouse()
    {
        Instantiate(objectToSpawn1, new Vector3(GetMouseWordPosition().x, GetMouseWordPosition().y, objectSpawner.transform.position.z), objectSpawner.transform.rotation);
        if (cebolaordem == true)
        {
            if (alhopronto == false)
            {
                alhoUi.SetActive(false);
                corteUi.SetActive(true);
                alhopronto = true;
            }

        }
        //instantiate the object in the mouse position with the same z position as the object spawner
    }
    public void SpawnObject2OnMouse()
    {
        Instantiate(objectToSpawn2, new Vector3(GetMouseWordPosition().x, GetMouseWordPosition().y, objectSpawner.transform.position.z), objectSpawner.transform.rotation);
        if (cebolapronto == false)
        {
            cebolaUi.SetActive(false);
            corteUi.SetActive(true);
            cebolapronto = true;
        }
    }
    public void SpawnObject3OnMouse()
    {
        Instantiate(objectToSpawn3, new Vector3(GetMouseWordPosition().x, GetMouseWordPosition().y, objectSpawner.transform.position.z), objectSpawner.transform.rotation);

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
    public void SpawnObject4OnMouse()
    {
        Instantiate(objectToSpawn4, new Vector3(GetMouseWordPosition().x, GetMouseWordPosition().y, objectSpawner.transform.position.z), objectSpawner.transform.rotation);


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


    public void SpawnObject5OnMouse()
    {
        Instantiate(objectToSpawn5, new Vector3(GetMouseWordPosition().x, GetMouseWordPosition().y, objectSpawner.transform.position.z), objectSpawner.transform.rotation);


        if (aguaordem == true)
        {
            if (baconpronto == false)
            {
                baconUi.SetActive(false);
                panelaUi.SetActive(true);
                baconpronto = true;
            }


        }
    }
}
