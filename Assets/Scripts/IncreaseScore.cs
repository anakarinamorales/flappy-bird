using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    /// <summary>
    /// When the player collides with the specified area between the pipes, it triggers the score method
    /// that increases the player score
    /// </summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreCounter.score++;
    }
}
