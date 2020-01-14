using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static int score;


    // Use this for initialization
    void Start()
    {
        score = 0;
    }

    /// <summary>
    /// Updates the text score with the updated score
    /// </summary>
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
