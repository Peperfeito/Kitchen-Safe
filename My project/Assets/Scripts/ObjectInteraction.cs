using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    // set the object tag in the inspector
    public string objectTag;
    public GameObject placedObject;
    public GameObject placedObjectPosition;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(objectTag))
        {
            Destroy(this.gameObject);
            Instantiate(placedObject, placedObjectPosition.transform.position, placedObjectPosition.transform.rotation);
        }

    }
}
