using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {
    public float timeBetweenSpawn = 1; //the time that we have to wait 'till create a new pipe
    private float timer = 0; // count the time that is passing
    public GameObject pipe; // pipe object reference
    public float height;

    // Use this for initialization
    void Start () {
        //GameObject newPipe = Instantiate(pipe);
        //newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    public void Spawn ()
    {
        if(timer > timeBetweenSpawn)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
        Spawn();
	}
}
