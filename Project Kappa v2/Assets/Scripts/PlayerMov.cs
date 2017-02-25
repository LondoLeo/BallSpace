using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {
    public float MovSpeed;
    public float Jump;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask Ground;
    public LayerMask Enemy;
    public bool isGround;

    public bool invincible = false;

    public bool GoombaStomp;

    public Death death;


	// Use this for initialization
	void Start () {

        death = FindObjectOfType<Death>();
		
	}

    void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, Ground);

        GoombaStomp = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, Enemy);

        if (GoombaStomp)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, Jump);
            invincible = true;
        }

        if (isGround)
        {
            invincible = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-MovSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(MovSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, Jump);
           
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            death.KillPlayer();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
