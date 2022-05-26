using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFirstLevel : MonoBehaviour
{
    void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
}
