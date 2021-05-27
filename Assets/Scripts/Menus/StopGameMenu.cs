using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopGameMenu : MonoBehaviour
{
    public void ContinueGame()
    {
        LevelManager.levelManager.gamePause = false;
        LevelManager.levelManager.gamePauseText.SetActive(false);
        Time.timeScale = 1f;
        
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

