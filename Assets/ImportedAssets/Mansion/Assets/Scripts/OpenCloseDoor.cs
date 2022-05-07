using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    public Animator anim;
    public AudioSource aud;
    public AudioClip[] audClips;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //the Player gameobject entered the trigger zone
    void OnTriggerEnter(Collider col)
    {
        //checking of the gameobject which entered the trigger zone is actually tagged as "Player"
        if (col.CompareTag("Player"))
        {
            //play "open" animation;
            anim.SetBool("open", true);
            //if the AudioSource is addigned - play first (open) sound
            if (aud != null)
                aud.clip = audClips[0];
                aud.Play();
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
            if (aud != null)
                aud.clip = audClips[1];
                aud.Play();
        }
    }
}
