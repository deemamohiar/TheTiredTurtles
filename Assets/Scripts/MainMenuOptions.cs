using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuOptions : MonoBehaviour
{
    public GameObject MainMenu;

    void Start()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        // Play music
        GameObject.FindGameObjectWithTag("MainMenuInstructionsAudio").GetComponent<KeepMusicPlaying>().PlayMusic();
    }

    public void StartGameButton()
    {
        // Load First Level
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }

    public void InstructionsButton() 
    {
        // Load Instructions Scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Instructions");
    }

    public void QuitGameButton()
    {
        // Quit Game
        Application.Quit();
    }
}