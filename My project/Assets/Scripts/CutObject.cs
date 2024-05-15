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

    private void OnMouseDown()
    {
                
            corteUi.SetActive(false);
            panelaUi.SetActive(true);
            Instantiate(cutObject, cutObjectPosition.transform.position, cutObjectPosition.transform.rotation);
            Destroy(this.gameObject);
        
    }
}