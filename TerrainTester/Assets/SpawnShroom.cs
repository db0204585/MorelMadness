using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShroom : MonoBehaviour {
    public GameObject shroom;

    // Use this for initialization
    void Start() {
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