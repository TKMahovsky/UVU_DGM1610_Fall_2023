using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{

    public float topBounds = 14.0f;
    public float bottomBounds = -14.0f;
    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy stray lasers
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        //Game Over message
        else if (transform.position.z < bottomBounds)
        {
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
