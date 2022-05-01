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