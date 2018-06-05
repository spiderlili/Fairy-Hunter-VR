using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour {

    public void LoadDayScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadNightScene()
    {
        SceneManager.LoadScene("NightScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

