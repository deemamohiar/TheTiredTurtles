using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSFX : MonoBehaviour
{

    public AudioSource footstep;

    // Use this for initialization
    CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && footstep.isPlaying == false)
        {
            footstep.volume = Random.Range(0.5f, 0.7f);
            footstep.pitch = Random.Range(0.8f, 1.1f);
            footstep.Play();
        }
    }
}
