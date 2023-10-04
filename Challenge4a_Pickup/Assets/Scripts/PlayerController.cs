using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 35;
    public float xRange = 21;
    public Transform blaster;
    public GameObject laserBolt;
    
    // Update is called once per frame
    void Update()
    {
        //Move left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //Left player bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        //Right player bounds
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        //Create laser bolt with space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }

    //Delete trigger objects that hit player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
