using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShroom : MonoBehaviour {
<<<<<<< HEAD
    public GameObject shroom; // create public variable shroom

    // Use this for initialization
    void Start() {
        shroom = GameObject.Find("shroom"); // set shroom to shroom.prefab
        int numShrooms = Random.Range(250, 501); // generate a random number
        for (int i = 0; i < numShrooms; i++) // loop until random number numShrooms is met
        {
            Vector3 temp = new Vector3(Random.Range(0, 501), Terrain.activeTerrain.SampleHeight(transform.position), Random.Range(0, 501)); // create a vector within the map terrain, with the y axis being on top of the terrain
            transform.position = temp; //
            Instantiate(shroom, temp + transform.TransformPoint(0, 0, 0), Quaternion.identity);
        }
    }
}
=======

    public GameObject shroom;
    // Use this for initialization
    void Start () {
        shroom = GameObject.Find("shroom");
        int numShrooms = Random.Range(250, 501);
        for (int i = 0; i < numShrooms; i++)
        {
            Vector3 temp = new Vector3(Random.Range(0, 501), Terrain.activeTerrain.SampleHeight(transform.position), Random.Range(0, 501));
            transform.position = temp;
            Instantiate(shroom, temp + transform.TransformPoint(0, 0, 0), Quaternion.identity);
        }
    }
	

}
>>>>>>> menu
