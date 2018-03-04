using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    // movement speed
    public float speed = 3;

    // flap force
    public float force = 300;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // restart the game
        Application.LoadLevel(Application.loadedLevel);
    }
}
