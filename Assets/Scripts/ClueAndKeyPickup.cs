using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ClueAndKeyPickup : MonoBehaviour
{
    public AudioSource scrollPickupSound;
    public AudioSource keyPickupSound;
    // public GameObject scroll;
    public TMP_Text scroll, keyNarrationText;
    GameObject image, clue2Obj, key1Obj, keyNarrationBackground;
    bool unlockedLevel2;
    void Start()
    {
        unlockedLevel2 = false;
        image = GameObject.Find("PapyrusPaper");
        clue2Obj = GameObject.Find("Clue2");
        key1Obj = GameObject.Find("Key1");
        keyNarrationBackground = GameObject.Find("KeyNarrationBackground");
        image.SetActive(false);
        scroll.enabled = false;
        keyNarrationBackground.SetActive(false);
    }
    public void PickupScroll()
    {
        clue2Obj.SetActive(false);
        scrollPickupSound.Play();
        StartCoroutine(ShowScroll());
    }
    public void PickupKey()
    {
        key1Obj.SetActive(false);
        // keyPickupSound.Play();
        StartCoroutine(BottomNaration("Hmm...\nThis must be the key to the frond door..."));
        unlockedLevel2 = true;
    }
    public IEnumerator ShowScroll()
    {
        image.SetActive(true);
        scroll.enabled = true;
        yield return new WaitForSeconds(10.0f);
        image.SetActive(false);
        scroll.enabled = false;
    }
    public IEnumerator BottomNaration(string message)
    {
        keyNarrationBackground.SetActive(true);
        keyNarrationText.SetText(message);
        keyNarrationText.enabled = true;
        yield return new WaitForSeconds(5.0f);
        keyNarrationBackground.SetActive(false);
        keyNarrationText.enabled = false;
    }
    public void SecondLevel()
    {
        if (unlockedLevel2 == true)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
        } else {
            StartCoroutine(BottomNaration("Looks like this door is locked..."));
        }
    }
}
