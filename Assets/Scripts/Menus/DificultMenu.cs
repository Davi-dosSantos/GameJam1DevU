using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DificultMenu : MonoBehaviour
{

    public void Facil()
    {
        SceneManager.LoadScene("fase1");
    }
    public void Medio()
    {
        SceneManager.LoadScene("fase1");
    }
    public void Dificil()
    {
        SceneManager.LoadScene("fase1");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
