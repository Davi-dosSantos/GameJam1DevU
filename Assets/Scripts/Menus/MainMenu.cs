using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Comandos");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Fontes()
    {
        SceneManager.LoadScene("Fontes");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
