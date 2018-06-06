using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectionCalculator : MonoBehaviour {
    public int counter;
    public TextMesh petsCollectedText;

    // Use this for initialization
    void Start () {
        counter = 0;
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void totalCount()
    {
        counter += 1;
        petsCollectedText.text = "Yokai Collected: " + counter.ToString();
        Debug.Log("Yokai Collected: " + counter);
    }
}
