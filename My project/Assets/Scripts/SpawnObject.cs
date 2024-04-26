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

    public void SpawnObject1()
    {
        Instantiate(objectToSpawn1, objectSpawner.transform.position, objectSpawner.transform.rotation);
        alhoUi.SetActive(false);
        corteUi.SetActive(true);
    }
    public void SpawnObject2()
    {
        Instantiate(objectToSpawn2, objectSpawner.transform.position, objectSpawner.transform.rotation);
        cebolaUi.SetActive(false);
        corteUi.SetActive(true);
    }
    public void SpawnObject3()
    {
        Instantiate(objectToSpawn3, objectSpawner.transform.position, objectSpawner.transform.rotation);
        aguaUi.SetActive(false);
        panelaUi.SetActive(true);
    }
    public void SpawnObject4()
    {
        Instantiate(objectToSpawn4, objectSpawner.transform.position, objectSpawner.transform.rotation);
        arrozUi.SetActive(false);
        panelaUi.SetActive(true);
    }
}
