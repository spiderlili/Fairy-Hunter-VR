using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour {
    collectionCalculator colCalc;
    int petCount = 0;
    public Text petCountText;
    public TextMeshProUGUI petCountTextMesh;

	// Use this for initialization
	void Start () {
        colCalc = FindObjectOfType<collectionCalculator>();
        petCount = colCalc.counter;
        petCountTextMesh.text = "Yokai Collected: " + petCount.ToString();
        Destroy(colCalc.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
