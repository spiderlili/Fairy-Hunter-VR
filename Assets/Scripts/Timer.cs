using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float timeRemaining;
    public TextMesh timertext;

    // Use this for initialization
    void Start () {
        
	}
	
	void Update () {
        timeRemaining -= Time.deltaTime;
        timertext.text = "Time Remaining: " + Mathf.Floor(timeRemaining).ToString() + " Seconds"; //round number

        if (timeRemaining < 1) {
            SceneManager.LoadScene("EndScene");
        }
    }
}
