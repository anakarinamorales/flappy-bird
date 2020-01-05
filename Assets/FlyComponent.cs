using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyComponent : MonoBehaviour {
    public float velocity = 1;
    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Jump
            rigidBody.velocity = Vector2.up * velocity;
        }
	}
}
