using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    public LayerMask HazardLayer;
    public LayerMask EnemyLayer;
    public Transform deathCheck;
    public float deathCheckRadius;

    public PlayerMov PlayerVar;

    public GameObject respawn;
    public Levelmanager levelmanager;

    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject Coin3;
    public GameObject Coin4;
    public GameObject Coin5;
    public GameObject Coin6;


    // Use this for initialization
    void Start () {
        levelmanager = FindObjectOfType<Levelmanager>();
        PlayerVar = FindObjectOfType<PlayerMov>();
	}
    public void KillPlayer()
    {
        transform.position = respawn.transform.position;
        levelmanager.CoinCount = 0;
        GetComponent<AudioSource>().Play();
        Coin1.GetComponent<SpriteRenderer>().enabled = true;
        Coin1.GetComponent<BoxCollider2D>().enabled = true;
        Coin2.GetComponent<SpriteRenderer>().enabled = true;
        Coin2.GetComponent<BoxCollider2D>().enabled = true;
        Coin3.GetComponent<SpriteRenderer>().enabled = true;
        Coin3.GetComponent<BoxCollider2D>().enabled = true;
        Coin4.GetComponent<SpriteRenderer>().enabled = true;
        Coin4.GetComponent<BoxCollider2D>().enabled = true;
        Coin5.GetComponent<SpriteRenderer>().enabled = true;
        Coin5.GetComponent<BoxCollider2D>().enabled = true;
        Coin6.GetComponent<SpriteRenderer>().enabled = true;
        Coin6.GetComponent<BoxCollider2D>().enabled = true;


    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if(Physics2D.OverlapCircle(deathCheck.position, deathCheckRadius, HazardLayer) || Physics2D.OverlapCircle(deathCheck.position, deathCheckRadius, EnemyLayer))
        {
            KillPlayer();
        }
		
	}
}
