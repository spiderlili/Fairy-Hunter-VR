using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// rotate the ball when shooted
	void Update () {
        transform.Rotate(new Vector3(300, 300, 300) * Time.deltaTime);
	}
}
