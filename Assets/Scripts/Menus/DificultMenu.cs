using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DificultMenu : MonoBehaviour
{
    
    public void Facil()
    {
        PlataformGerator.plataformGerator.NumKeysWin = 10;
        PlayerControl.playerControl.speedBase = 5;
        LevelManager.levelManager.gameDificultText.SetActive(false);
        Time.timeScale = 1f;
         
        
    }
    public void Medio()
    {
        PlataformGerator.plataformGerator.NumKeysWin = 20;
        PlayerControl.playerControl.speedBase = 7;
        LevelManager.levelManager.gameDificultText.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Dificil()
    {
        PlataformGerator.plataformGerator.NumKeysWin = 50;
        PlayerControl.playerControl.speedBase = 10;
        LevelManager.levelManager.gameDificultText.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Voltar()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
