using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BookAndPaintingInteract : MonoBehaviour
{
    
    // public AudioSource bookPickupSound;
    public AudioSource scrollPickupEffect;
    public TMP_Text scroll, bookNarrationText;
    GameObject image, bookObj, deemoh, consta, babriel, lysol, lisaWall, lisaWallDoor, bookNarrationBackground, endScroll;
    public GameObject[] paintings;
    public Text hint;
    void Start()
    {
        image = GameObject.Find("PapyrusPaper");
        bookObj = GameObject.Find("ZA7");
        image.SetActive(false);
        scroll.enabled = false;

        bookNarrationBackground = GameObject.Find("BookNarrationBackground");
        bookNarrationText.enabled = false;
        bookNarrationBackground.SetActive(false);

        endScroll = GameObject.Find("EndingScroll");

        lisaWall = GameObject.Find("LisaWall");
        lisaWallDoor = GameObject.Find("LisaWallDoor");
        lisaWall.SetActive(true);
        lisaWallDoor.SetActive(false);


        //paintings uninteract paintings
        for (int i = 0; i < paintings.Length; i++)
        {
            paintings[i].gameObject.GetComponent<Interactable>().enabled = false;
        }
    }

    public void PickupBook()
    {
        for (int i = 0; i < paintings.Length; i++)
        {
            paintings[i].gameObject.GetComponent<Interactable>().enabled = true;
        }
        bookObj.SetActive(false);
        // bookPickupSound.Play();
        scrollPickupEffect.Play();
        StartCoroutine(ShowScroll());
        StartCoroutine(BottomNarationAfterScroll("Hmm...\neyes are the window to the soul, eyes..."));
        
    }
    public void InteractWithPaintings(int index)
    {
        if(paintings[index].GetComponent<Interactable>().enabled != true)
        {
            StartCoroutine(BottomNarationWhenInteractingWithPainting("What am I doing?\nI should look for the clue..."));
            Debug.Log("Cant do anything");
        }
        else if(paintings[index].GetComponent<Interactable>().enabled == true)
        {
            if(paintings[index] == paintings[3])
            {
                Debug.Log("END LEVEL TIME");
                lisaWall.SetActive(false);
                lisaWallDoor.SetActive(true);
            }
            scrollPickupEffect.Play();
            paintings[index].SetActive(false);
        }
    }
    public IEnumerator ShowScroll()
    {
        image.SetActive(true);
        scroll.enabled = true;
        hint.text = "Eyes are the window to the soul, the closer to your eyes, the closer to your goal";
        yield return new WaitForSeconds(7.0f);
        image.SetActive(false);
        scroll.enabled = false;
    }
    public IEnumerator BottomNarationAfterScroll(string message)
    {
        yield return new WaitForSeconds(8.0f);
        bookNarrationBackground.SetActive(true);
        bookNarrationText.SetText(message);
        bookNarrationText.enabled = true;
        yield return new WaitForSeconds(5.0f);
        bookNarrationBackground.SetActive(false);
        bookNarrationText.enabled = false;
    }
    public IEnumerator BottomNarationWhenInteractingWithPainting(string message)
    {
        bookNarrationBackground.SetActive(true);
        bookNarrationText.SetText(message);
        bookNarrationText.enabled = true;
        yield return new WaitForSeconds(5.0f);
        bookNarrationBackground.SetActive(false);
        bookNarrationText.enabled = false;
    }
    public void EndLevel()
    {
        scrollPickupEffect.Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("EndingSequence");
    }
}
