using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    //public GameObject gameOverCanvas;
    public Canvas gameOverCanvas;

	// Use this for initialization
	void Start () {
       //gameOverCanvas = GetComponent<Canvas>();
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
    }
}
