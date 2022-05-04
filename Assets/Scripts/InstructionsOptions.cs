using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsOptions : MonoBehaviour
{
    public GameObject Instructions;

    void Start()
    {
        // Show Main Menu
        Instructions.SetActive(true);
    }

    public void BackHomeButton() 
    {
        // Load Instructions Scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}