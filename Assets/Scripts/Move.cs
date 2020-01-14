using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    /// <summary>
    /// Once per frame, this method moves the pipe to the left
    /// based on the setted speed
    /// </summary>
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
