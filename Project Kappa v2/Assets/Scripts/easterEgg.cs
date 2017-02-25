using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easterEgg : MonoBehaviour {
    public GameObject EasterSquare;
    public GameObject Player;
    public Color easterColor;


    private void OnTriggerEnter2D(Collider2D other)
    {
        EasterSquare.GetComponent<SpriteRenderer>().enabled = false;
        Player.GetComponent<SpriteRenderer>().color = easterColor;
        GetComponent<AudioSource>().Play();
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
