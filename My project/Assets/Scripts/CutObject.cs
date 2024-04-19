using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutObject : MonoBehaviour
{
    public GameObject cutObject;
    public GameObject cutObjectPosition;

    private void OnMouseDown()
    {
        Instantiate(cutObject, cutObjectPosition.transform.position, cutObjectPosition.transform.rotation);
        Destroy(this.gameObject);
    }
}