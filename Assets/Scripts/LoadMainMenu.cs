using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMainMenu : MonoBehaviour
{
    void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
