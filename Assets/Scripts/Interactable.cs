using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange = false;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag.ToString() == "LilyTag")
        {
            isInRange = true;
            Debug.Log("Lily is in range");

        }
    }
    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag.ToString() == "LilyTag")
        {
            isInRange = false;
            Debug.Log("Lily is not in range");
            
        }
    }
    public void showNextClue()
    {
        Debug.Log("here is the cluee lalala");
    }
}
