using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager: MonoBehaviour {

    public string LevelSelect;
    public string Credits;


	public void ButtonPlay(){
	
		SceneManager.LoadScene (LevelSelect);
	
	}

    public void ButtonCredits()
    {
        SceneManager.LoadScene(Credits);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
