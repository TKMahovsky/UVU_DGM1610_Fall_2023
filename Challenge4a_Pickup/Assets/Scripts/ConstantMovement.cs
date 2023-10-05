using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float moveDistance = 42.0f; 

    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private bool movingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + new Vector3(moveDistance, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if should change direction
        if (transform.position.x >= targetPosition.x && movingRight)
        {
            movingRight = false;
        }
        else if (transform.position.x <= initialPosition.x && !movingRight)
        {
            movingRight = true;
        }

        // Move right else move left
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}
