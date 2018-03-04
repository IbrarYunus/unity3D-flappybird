using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

    public GameObject obstacles;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateObstacle()
    {
        Instantiate(obstacles);
    }
}
