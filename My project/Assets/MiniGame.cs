using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    public string objectTag;
    public GameObject Trigger1;
    public GameObject Trigger2;
    public int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(objectTag))
        {
            ++score;
        }

    }
}
