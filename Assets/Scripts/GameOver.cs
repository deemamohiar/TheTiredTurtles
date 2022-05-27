using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    bool isCursorLocked = false;
    void Start()
    {
        Cursor.lockState = isCursorLocked ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !isCursorLocked;
    }
    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
