using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float timeBetweenSpawn = 1; //the time that we have to wait 'till create a new pipe
    private float timer = 0; // count the time that is passing
    public GameObject pipe; // pipe object reference
    public float height; // the scene height

    /// <summary>
    /// Initializes the game creating a pipe and destroying it after a while
    /// </summary>
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 15);
    }

    /// <summary>
    /// The Spawn() method create a new pipe element in the scene in random positions based in the heigth of the scene
    /// and destroys each created pipe after a while, to not overload the game with unused objects
    /// </summary>
    public void Spawn()
    {
        if (timer > timeBetweenSpawn)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    /// <summary>
    /// Once per frame calls the Spawn() method
    /// </summary>
    void Update()
    {
        Spawn();
    }
}
