using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingCollectibles : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.3f;

    float initialY;

    void Start()
    {
        // starting y position 
       initialY = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float currentHeight = Mathf.PingPong(Time.time * speed, 0.3f) * 3 + initialY;
        gameObject.transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

    }
}
