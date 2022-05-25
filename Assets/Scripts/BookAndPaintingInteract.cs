using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BookAndPaintingInteract : MonoBehaviour
{
    
    public AudioSource bookPickupSound;
    public TMP_Text scroll;
    GameObject image, bookObj, deemoh, consta, babriel, lysol;
    public GameObject[] paintings;
    bool unlockedPainting;
    public Text hint;
    void Start()
    {
        unlockedPainting = false;
        image = GameObject.Find("PapyrusPaper");
        bookObj = GameObject.Find("ZA7");
        image.SetActive(false);
        scroll.enabled = false;
    }
    public void PickupBook()
    {
        bookObj.SetActive(false);
        unlockedPainting = true;
        bookPickupSound.Play();
        StartCoroutine(ShowScroll());
    }
    public void InteractWithPaintings(int index)
    {
        paintings[index].SetActive(false);
    }    
    public IEnumerator ShowScroll()
    {
        image.SetActive(true);
        scroll.enabled = true;
        hint.text = "Eyes are the window to the soul, the closer to your eyes, the closer to your goal";
        yield return new WaitForSeconds(10.0f);
        image.SetActive(false);
        scroll.enabled = false;
    }
    public void EndLevel()
    {
        if (unlockedPainting == true)
        {//TODO: change to correct scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }
}
