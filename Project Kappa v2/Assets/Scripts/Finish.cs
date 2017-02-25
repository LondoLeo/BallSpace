using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {
    public Levelmanager levelmanager;
    public GameObject player;
    public bool flyState = false;

    public string nextScene;

    public AudioClip[] sounds;

    private int i;


	// Use this for initialization
	void Start () {
        levelmanager = FindObjectOfType<Levelmanager>();
    
		
	}
	
	// Update is called once per frame
	void Update () {

        if (flyState)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3);
            i++;
        }

        if(i >= 500)
        {
            SceneManager.LoadScene(nextScene);
        }
		
	}

    void DoNothing()
    {

    }

    void PlaySound1()
    {
        GetComponent<AudioSource>().clip = sounds[0];
        GetComponent<AudioSource>().Play();
    }
    void PlaySound2()
    {
        GetComponent<AudioSource>().clip = sounds[1];
        GetComponent<AudioSource>().Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (levelmanager.CoinCount == 6)
        {
            levelmanager.GetComponent<AudioSource>().Stop();
            player.GetComponent<SpriteRenderer>().enabled = false;
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            flyState = true;
            PlaySound1();
            Invoke("PlaySound2", 1);
            
           
        }
    }
}
