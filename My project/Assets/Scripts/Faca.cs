using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Faca : MonoBehaviour
{
    //make the object sprite a variable
    public SpriteRenderer mainSprite;
    public SpriteRenderer cutSprite;
    //make the tag a variable
    public string mainObjectTag;
    public string cutObjectTag;
    // Start is called before the first frame update
    void Start()
    {
        mainSprite = GetComponent<SpriteRenderer>();
        mainObjectTag = gameObject.tag;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Faca"))
        {
            mainSprite= cutSprite;
            mainObjectTag = cutObjectTag;
        }
    }
}
