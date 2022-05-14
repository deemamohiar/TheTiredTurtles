using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCloseDoor : MonoBehaviour
{
    public Animator anim;
    public AudioSource aud;
    public AudioClip[] audClips;
    public static bool isDoorUnlocked;

    public static string currentLevel; 

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
        isDoorUnlocked = CollectItems.isKeyCollected;

        //checking of the gameobject which entered the trigger zone is actually tagged as "Player"
        if (col.CompareTag("Player") && isDoorUnlocked && currentLevel == "Level1")
        {
            hasDoorBeenOpened= true;
            //play "open" animation;
            anim.SetBool("open", true);
            //if the AudioSource is addigned - play first (open) sound
            if (aud != null)
                aud.clip = audClips[0];
                aud.Play(); 
            
            // transition to next level
            LoadSecondLevel loadSecondLevel = new LoadSecondLevel();
        }
        // only open doors in level 2 that are not doors leading outside the house
        else if (col.CompareTag("Player") && currentLevel == "Level2" && gameObject.tag != "EntranceDoors") {
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
                aud.Play();
        }
    }
}
