using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioBlocker : MonoBehaviour
{
    public AudioSource a1;
    public AudioSource a2;
    public AudioSource a3;
    public AudioSource a4;
    public AudioSource a5;
    // Start is called before the first frame update
    void Start()
    {
        a1.playOnAwake = false;
        a2.playOnAwake = false;
        a3.playOnAwake = false;
        a4.playOnAwake = false;
        a5.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
