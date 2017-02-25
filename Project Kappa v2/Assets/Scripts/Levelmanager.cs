using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour {

    public int CoinCount;
    public Transform Respawn;
    public Transform Finish;
    public GameObject Player;

    public GUIStyle Score;
    public Font newFont;
    public Color GUIcolor;

    private void OnGUI()
    {
        Score.fontSize = 40;
        Score.font = newFont;
        Score.alignment = TextAnchor.UpperCenter;
        
        Score.normal.textColor = GUIcolor;
        GUI.Label(new Rect(0, 10, Screen.width, Screen.height), CoinCount + " / 6", Score);
        
    }



    // Use this for initialization
    void Start () {

        Player.GetComponent<SpriteRenderer>().color = Color.blue;
 
		
	}
	
	// Update is called once per frame
	void Update () {
        



    }

   
}
