using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyComponent : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rigidBody;
    public GameManager gameManager;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Jump
            rigidBody.velocity = Vector2.up * velocity;
        }
    }

    /// <summary>
    /// This method will be automatically called when the bird hit something
    /// triggering the game over method
    /// </summary>
    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
