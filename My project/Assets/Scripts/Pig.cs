using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    public float maxSpeed;
    private float waitTime;
    public float startWaitTime;
    public Vector3 direction;
    private Vector3 lastPosition;

    [SerializeField] Animator Porco;

    public Transform[] moveSpots;
    private int randomSpot;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = transform.position - lastPosition;

        direction = delta.normalized;

        if (Mathf.Abs(direction.y) > 0.1f)
        {

            if (Mathf.Abs(direction.y) > 0f)
            {

                //se a posi��o de y for menor que a �ltima posi��o = y diminuir
                if (transform.position.y < lastPosition.y)
                {
                    /// faz o eixo Z ficar em 0

                    Porco.Play("AndasFrente");

                }

                else
                {

                    Porco.Play("AndasTras");

                }
            }
            else if (Mathf.Abs(direction.x) > 0f)
            {

                Porco.Play("AndasTras");

            }

        }
        else if (Mathf.Abs(direction.x) > 0.1f)
        {

            if (direction.x > 0)
            {

                Porco.Play("AndasDireita");

            }
            else if (direction.x < 0)
            {

                Porco.Play("AndasEsquerda");

            }

        }

        lastPosition = transform.position;


        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, maxSpeed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
    private void OnMouseDown()
    {
        maxSpeed = 0;
    }
    private void OnMouseExit()
    {
        maxSpeed = 10;
    }
    }
