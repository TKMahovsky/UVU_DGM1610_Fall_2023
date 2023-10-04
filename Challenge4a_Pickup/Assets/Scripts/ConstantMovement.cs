using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float xRange = 21.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move right
        if (transform.position.x < xRange)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        //Move left
        else if (transform.position.x == xRange)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
