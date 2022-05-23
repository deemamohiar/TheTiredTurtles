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
    void Start()
    {
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
        StartCoroutine(BottomNaration());
        
    }
    public IEnumerator ShowScroll()
    {
        image.SetActive(true);
        scroll.enabled = true;
        yield return new WaitForSeconds(10.0f);
        image.SetActive(false);
        scroll.enabled = false;
    }
    public IEnumerator BottomNaration()
    {
        keyNarrationBackground.SetActive(true);
        keyNarrationText.enabled = true;
        yield return new WaitForSeconds(10.0f);
        keyNarrationBackground.SetActive(false);
        keyNarrationText.enabled = false;
    }
}
