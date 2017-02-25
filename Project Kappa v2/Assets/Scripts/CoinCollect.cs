using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {
    public Levelmanager levelmanager;
 



    void Start()
    {
  
        levelmanager = FindObjectOfType<Levelmanager>();

    }

    void DestroyCoin()
    {
        gameObject.SetActive(false);
    }
  
    void OnTriggerEnter2D(Collider2D other)
      {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        levelmanager.CoinCount++;      
      }
}
