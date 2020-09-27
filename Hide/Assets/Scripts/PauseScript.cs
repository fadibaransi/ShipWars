using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

     bool isGamePaused = false;
    public GameObject ui;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            if(isGamePaused){
                Resume();
            }else{
                Pause();
            }

        }
	}

    public void Resume()
    {
        ui.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;

    }

    void Pause()
    {
       
         ui.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameStart");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting the game");
        Application.Quit();
        
    }
}
