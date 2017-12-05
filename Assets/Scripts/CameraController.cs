using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = new Vector3(ball.transform.position.x, ball.transform.position.y + 1, ball.transform.position.z - 1);
        transform.position = pos;
	}
}
