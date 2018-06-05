using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetsCollected : MonoBehaviour {

    public int counter;
    collectionCalculator collectionCalc;

	// Use this for initialization
	void Start () {
        counter = 0;
        collectionCalc = FindObjectOfType<collectionCalculator>();

    }
	
    //destroy the magic ball and caught pet at the same time
	public void OnTriggerEnter(Collider collide) {
        if (collide.gameObject.CompareTag("violetBat")) {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            collectionCalc.totalCount();
        }
        if (collide.gameObject.CompareTag("yellowBunny"))
        {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            collectionCalc.totalCount();
        }
        if (collide.gameObject.CompareTag("greenSlime"))
        {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            collectionCalc.totalCount();
        }
        if (collide.gameObject.CompareTag("whiteGhost"))
        {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            collectionCalc.totalCount();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground")) {
            Destroy(gameObject);
        }
    }
}
