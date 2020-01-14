using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public Canvas gameOverCanvas;
    private GameManager gameManager;

    // Use this for initialization
    void Awake ()
    {
        gameOverCanvas.enabled = false; // hides the canvas with the game over message
        Time.timeScale = 1;
    }

    public void GameOver ()
    {
        gameOverCanvas.enabled = true; // shows the canvas with the game over message
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0;

    }

    // restarts the game
    public void Replay ()
    {
        gameOverCanvas.enabled = false; // hides the canvas with the game over message
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
