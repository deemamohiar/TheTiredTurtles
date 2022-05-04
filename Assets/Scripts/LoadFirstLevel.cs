using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFirstLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
}
