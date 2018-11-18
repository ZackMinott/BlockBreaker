using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameStatus : MonoBehaviour {
    //config params
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int scorePerBlockDestroyed = 5;
    [SerializeField] TextMeshProUGUI scoreText;    

    //state variables
    [SerializeField] int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            Destroy(gameObject); // Destroy this game Object
        }
        else
        {
            DontDestroyOnLoad(gameObject); //Doesn't destroy this on loading the next scene
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString(); //score should equal zero
    }

    // Update is called once per frame
    void Update () {
        Time.timeScale = gameSpeed;
	}

    public void AddToScore()
    {
        currentScore += scorePerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
}
