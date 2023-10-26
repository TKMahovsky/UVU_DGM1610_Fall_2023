using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public GameManager gameManager;
    public float topBounds = 14.0f;
    public float bottomBounds = -14.0f;
    void Awake()
    {
        Time.timeScale = 1;
    }

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
            gameManager.EndGame();
            Debug.Log("Game Over!");
            //Time.timeScale = 0;
        }
    }
}
