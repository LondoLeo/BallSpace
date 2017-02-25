using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public int enemyMoveVert;
    public bool u;
    public int i;

	// Use this for initialization
	void Start () {
		
	}

    private void FixedUpdate()
    {
        if (!u)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -2);
            i--;
            u = (i == -enemyMoveVert);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2);
            i++;
            u = !(i == enemyMoveVert);
        }
    }
 


	
	// Update is called once per frame
	void Update () {
        
    
    }
}
