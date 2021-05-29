using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMedio : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Fase-Medio");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("DificultSelector");
    }
}
