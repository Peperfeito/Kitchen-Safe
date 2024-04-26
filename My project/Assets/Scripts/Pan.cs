using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    public GameObject alhoUi;
    public GameObject panelaUi;
    public GameObject arrozUi;
    public GameObject aguaUi;
    public GameObject prontoUi;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cebola"))
        {
            panelaUi.SetActive(false);
            alhoUi.SetActive(true);

        }

        if (collision.gameObject.CompareTag("Alho"))
        {
            panelaUi.SetActive(false);
            arrozUi.SetActive(true);

        }

        if (collision.gameObject.CompareTag("Arroz"))
        {
            Destroy(collision.gameObject);
            panelaUi.SetActive(false);
            aguaUi.SetActive(true);

        }

        if (collision.gameObject.CompareTag("Agua"))
        {
            Destroy(collision.gameObject);
            panelaUi.SetActive(false);
            prontoUi.SetActive(true);

        }

    }
}
