using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static bool isGamePaused = false;
    public Player player;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
        if(player.GetComponent<Player>().Life == 0)
        {
            GameOver();
        }
        
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isGamePaused = false;
    }

    public void Paused()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isGamePaused = true;
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
