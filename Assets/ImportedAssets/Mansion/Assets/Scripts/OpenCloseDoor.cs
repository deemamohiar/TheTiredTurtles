using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenCloseDoor : MonoBehaviour
{
    public Animator anim;
    public AudioSource aud;
    public AudioClip[] audClips;
    public static bool isDoorUnlocked;
    public static string currentLevel; 

    // get image and animator to fade out into next level
    public Image blackImage;
    public Animator animatorImage;

    // being used so that closing door sound doesnt play if the door hasnt
    // been opened to begin with
    public bool hasDoorBeenOpened= false;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        currentLevel = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
    }
    //the Player gameobject entered the trigger zone
    void OnTriggerEnter(Collider col)
    {
        //checking of the gameobject which entered the trigger zone is actually tagged as "Player"
        if (col.CompareTag("Player") && 
        isDoorUnlocked && currentLevel == "Level1")
        {
            hasDoorBeenOpened= true;
            //play "open" animation;
            anim.SetBool("open", true);
            //if the AudioSource is addigned - play first (open) sound
            if (aud != null) {
                aud.clip = audClips[0];
                aud.Play(); 
            }
           StartCoroutine(FadingOut());
        }
        // only open doors in level 2 that are not doors leading outside the house
        else if (col.CompareTag("Player") && 
        currentLevel == "Level2" && gameObject.tag != "EntranceDoors") {
            hasDoorBeenOpened= true;
            //play "open" animation;
            anim.SetBool("open", true);
            //if the AudioSource is addigned - play first (open) sound
            if (aud != null)
                aud.clip = audClips[0];
                aud.Play();

        }
        else {
            hasDoorBeenOpened = false;
        }
    }
    //the Player gameobject left the trigger zone
    void OnTriggerExit(Collider col)
    {
        //checking of the gameobject which left the trigger zone is actually tagged as "Player"
        if (col.CompareTag("Player"))
        {
            //play "close" animation; 
            anim.SetBool("open", false);
            //if the AudioSource is addigned - play second (close) sound
            if (aud != null && hasDoorBeenOpened)
                aud.clip = audClips[1];
                // aud.Play();
        }
    }

    public IEnumerator FadingOut() {
        // // transition to next level
        // animatorImage.SetBool("FadeOut", true);
        // // Debug.Log("Fade out is: " + animatorImage.GetBool("FadeOut"));
        // // make sure fading out has finished before transitioning to next scene
        // if (!this.animatorImage.GetCurrentAnimatorStateInfo(0).IsName("FadeOutOfLevel1"))
        // {
        //     yield return new WaitUntil(() => blackImage.color.a==1);
        // }
        // else{
        //     SceneManager.LoadScene("Level2Title");
        // }
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level2Title");
    }


}
