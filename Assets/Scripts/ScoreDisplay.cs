using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    collectionCalculator colCalc;
    int petCount = 0;
    public Text petCountText;
	// Use this for initialization
	void Start () {
        colCalc = FindObjectOfType<collectionCalculator>();
        petCount = colCalc.counter;
        petCountText.text = "Pets Collected: " + petCount.ToString();
        Destroy(colCalc.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
