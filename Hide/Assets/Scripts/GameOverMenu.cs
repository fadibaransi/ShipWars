using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour {

    public GameObject ui;
    public GameObject Player;
    public Text scoreText;

	
	// Update is called once per frame
	void Update () {

        if (!Player.gameObject.GetComponent<PlayerMovement>().PlayerIsAlive)
        {
            LoadGameOverScene();
        }
	}

    void LoadGameOverScene()
    {
        ui.SetActive(true);
        scoreText.text = (Player.gameObject.GetComponent<PlayerMovement>().points).ToString();
       // Time.timeScale = 0f;

    }

    public void Restart()
    {
        ui.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    

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
