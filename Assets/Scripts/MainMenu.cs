using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SelectDifficulty()
    {
        SceneManager.LoadSceneAsync("SelectDifficulty");
    }

    public void PlayGameEasy()
    {
        SceneManager.LoadSceneAsync("PlayGameEasy");
        BirdScript.birdIsAlive = true;
    }

    public void PlayGameNormal()
    {
        SceneManager.LoadSceneAsync("PlayGameNormal");
        BirdScript.birdIsAlive = true;
    }

    public void PlayGameHard()
    {
        SceneManager.LoadSceneAsync("PlayGameHard");
        BirdScript.birdIsAlive = true;
    }





    public void BackToMenuWeb()
    {
        SceneManager.LoadSceneAsync("MainMenuWeb");
    }






    public void QuitGame()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
