using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClueAndKeyPickup : MonoBehaviour
{
    public AudioSource scrollPickupSound;
    public AudioSource keyPickupSound;
    // public bool isInRange = false;
    // public KeyCode interactKey;
    // public UnityEvent interactAction;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.ToString() == "Clue2Tag")
        {
            Debug.Log("in Range");
            if(Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("picked up clue");
                collision.gameObject.SetActive(false);
                //show scroll for a few seconds
                //scrollPickupSound.Play();
            }

        }
        else if (collision.gameObject.tag.ToString() == "KeyTag")
        {
            Debug.Log("in Range");
            if(Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("picked up key");
                collision.gameObject.SetActive(false);
                //show scroll for a few seconds
                //scrollPickupSound.Play();
            }
        }
    }
}
