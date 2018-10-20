using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

    public string mainMenuLevel;
   

    // Use this for initialization
    public void RestartGame () {
        FindObjectOfType<GameManager>().Reset();
	}
	
	// Update is called once per frame
	public void QuitToMain () {

        SceneManager.LoadScene(mainMenuLevel);


    }
}
