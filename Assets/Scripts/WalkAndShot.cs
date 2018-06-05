using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAndShot : MonoBehaviour {
    public GameObject spawnMagicBall;
    public float shootingSpeed = 10.0f;
    public float walkingSpeed = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //move the player forward automatically
        transform.position = transform.position + Camera.main.transform.forward * walkingSpeed * Time.deltaTime;

        if (Input.GetButtonDown("Fire1")) {
            GameObject magicBall = Instantiate(spawnMagicBall);
            magicBall.transform.position = transform.position; //position of playerCamera
            Rigidbody rb = magicBall.GetComponent<Rigidbody>();
            Camera cam = GetComponentInChildren<Camera>();

            //shoot the ball from playerCamera's position
            rb.velocity = cam.transform.rotation * Vector3.forward * shootingSpeed; 
        }
	}
}
