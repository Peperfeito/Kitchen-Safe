using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerca : MonoBehaviour
{

    [SerializeField] GameObject porquinho;
    [SerializeField] GameObject porquinho2;
    [SerializeField] GameObject porquinho3;
    [SerializeField] GameObject porquinho4;
    [SerializeField] GameObject botaoprox;

    private bool porkcerca1 = false;
    private bool porkcerca2 = false;
    private bool porkcerca3 = false;
    private bool porkcerca4 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Porco"))
        {
            porquinho.SetActive(true);
            porkcerca1 = true;

                if(porkcerca1 == true)
                {
                    if (porkcerca2 == true)
                    {
                        if (porkcerca3 == true)
                        {
                            if (porkcerca4 == true)
                            {
                            botaoprox.SetActive(true);
                            }
                        }
                    }
                }

            Destroy(collision.gameObject);

        }

        if (collision.gameObject.CompareTag("Porco2"))
        {
            porquinho2.SetActive(true);
            porkcerca2 = true;

            Destroy(collision.gameObject);
            if (porkcerca1 == true)
            {
                if (porkcerca2 == true)
                {
                    if (porkcerca3 == true)
                    {
                        if (porkcerca4 == true)
                        {
                            botaoprox.SetActive(true);
                        }
                    }
                }
            }
        }

        if (collision.gameObject.CompareTag("Porco3"))
        {
            porquinho3.SetActive(true);
            porkcerca3 = true;

            Destroy(collision.gameObject);
            if (porkcerca1 == true)
            {
                if (porkcerca2 == true)
                {
                    if (porkcerca3 == true)
                    {
                        if (porkcerca4 == true)
                        {
                            botaoprox.SetActive(true);
                        }
                    }
                }
            }

        }

        if (collision.gameObject.CompareTag("Porco4"))
        {
            porquinho4.SetActive(true);
            porkcerca4 = true;

            Destroy(collision.gameObject);
            if (porkcerca1 == true)
            {
                if (porkcerca2 == true)
                {
                    if (porkcerca3 == true)
                    {
                        if (porkcerca4 == true)
                        {
                            botaoprox.SetActive(true);
                        }
                    }
                }
            }

        }
    }
}
