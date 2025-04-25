using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    private TargetShooter _scoreDisplay;
    private FiringTimeLimit _gameTime;

    private void Start()
    {
        
    }

    private void Update()
    {
        //If this timer isn't assigned, does nothing
        if (!_gameTime)
        {
            return;
        }

        if (_gameTime.TimeRemaining <= 0)
        {
            ShowScoreScreen();
        }
    }

    private void ShowScoreScreen()
    {

    }

    public void ResetGame()
    {
        //Reloads the main game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
