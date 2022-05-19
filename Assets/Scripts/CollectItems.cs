using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public static bool isKeyCollected = false;
    public static bool isClueCollected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        GameObject item = other.gameObject;

        if(item.name == "Key1") {
            isKeyCollected = true;
            // TODO Babriel: this is the part where u could call another script that u create that adds it to the HUD
            // Before destroying add it to HUD so u dont get error
            Destroy(item);
        }
        else if(item.name == "Clue2") {
            isClueCollected = true;
            //TODO Babriel: add clue to HUD before destroying (better if u create 
            // its own script and call the method or wtv here)
            Destroy(item);
        }
        
        if(isKeyCollected && isClueCollected) {
            OpenCloseDoor.isDoorUnlocked = true;
        }
    } 

}
