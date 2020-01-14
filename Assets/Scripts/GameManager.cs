using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public Canvas startCanvas;
    private GameManager gameManager;

    void Start()
    {
        gameOverCanvas.enabled = false; // hides the canvas with the game over message
        Time.timeScale = 0;
    }

    /// <summary>
    /// This function runs the game over action when the player hit a pipe, 
    /// or the ground or the screen boundaries (top, right, bottom. left).
    /// This action will stops the game and call the game over canvas, showing
    /// a game over message and a button to replay the game
    /// </summary>
    public void GameOver()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;

    }
    /// <summary>
    /// This function restarts the game disabling the game over canvas, loands the inicial scene and
    /// set the actual timeScale to 1 again
    /// </summary>
    // restarts the game
    public void Replay()
    {
        gameOverCanvas.enabled = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /// <summary>
    /// This function starts the game, disabling the start canvas and setting the timeScale to 1
    /// </summary>
    public void StartGame()
    {
        startCanvas = GameObject.Find("startCanvas").GetComponent<Canvas>(); // gets the startCanvas reference from the GameObject tree

        if (startCanvas != null)
        {
            startCanvas.enabled = false;
            Time.timeScale = 1;
        }
        else
        {
            Debug.Log("Could not locate startCanvas component.");
        }
    }
}