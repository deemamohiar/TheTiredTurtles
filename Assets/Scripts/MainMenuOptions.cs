using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuOptions : MonoBehaviour
{
    public GameObject MainMenu;
    private GameObject[] audioCount;

    void Start()
    {
        // Show Main Menu
        MainMenu.SetActive(true);

        // Make sure background audio doesn't get duplicated from the "DontDestroyOnLoad" method
        audioCount = GameObject.FindGameObjectsWithTag("MainMenuInstructionsAudio");
        if (audioCount.Length > 1) {
            Object.Destroy(GameObject.FindGameObjectsWithTag("MainMenuInstructionsAudio")[1]);
        }
    }

    public void StartGameButton()
    {
        // Load intro scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Intro");
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