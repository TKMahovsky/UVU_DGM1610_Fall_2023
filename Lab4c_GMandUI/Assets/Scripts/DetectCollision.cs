using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager and reference the component
    }
    
    void OnTriggerEnter(Collider other) // Record collisions in variable other
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase the score
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
