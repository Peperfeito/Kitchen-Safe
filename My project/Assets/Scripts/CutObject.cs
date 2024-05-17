using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutObject : MonoBehaviour
{
    public GameObject cutObject;
    public GameObject cutObjectPosition;
    public GameObject corteUi;
    public GameObject panelaUi;

    SpawnObject spawn;

    private void Start()
    {
        spawn = GameObject.Find("SpawnerManager").GetComponent<SpawnObject>();


    }
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Cebola"))
        {
            if (!spawn.cebolacorte)
            {
                corteUi.SetActive(false);
                panelaUi.SetActive(true);
                spawn.cebolacorte = true;
            }
        }

        if (gameObject.CompareTag("Alho"))
        {
            if (spawn.alhopronto)
            {
                if (!spawn.alhocorte)
                {
                    corteUi.SetActive(false);
                    panelaUi.SetActive(true);
                    spawn.alhocorte = true;

                }
            }
        }
        Instantiate(cutObject, cutObjectPosition.transform.position, cutObjectPosition.transform.rotation);
            Destroy(this.gameObject);
        
    }
}