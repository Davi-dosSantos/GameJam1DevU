using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DificultMenu : MonoBehaviour
{

    public void Facil()
    {
        SceneManager.LoadScene("fase1");
        LevelManager.levelManager.SetKeysMaxAndBaseSpeed(10, 5);
    }
    public void Medio()
    {
        LevelManager.levelManager.SetKeysMaxAndBaseSpeed(20, 7);
        SceneManager.LoadScene("fase1");
    }
    public void Dificil()
    {
        LevelManager.levelManager.SetKeysMaxAndBaseSpeed(50, 10);
        SceneManager.LoadScene("fase1");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
