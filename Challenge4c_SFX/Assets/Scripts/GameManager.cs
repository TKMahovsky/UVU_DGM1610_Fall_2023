using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public GameObject gameOverText;
    public AK.Wwise.Event loseGameSound;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        gameOverText.gameObject.SetActive(false); // Unhide UI text

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) // End game if isGameOver is true
        {
            EndGame();
        }

    }
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); // Unhide UI text
        Debug.Log("EndGame");
        Time.timeScale = 0;
        loseGameSound.Post(gameObject);
    }
}
