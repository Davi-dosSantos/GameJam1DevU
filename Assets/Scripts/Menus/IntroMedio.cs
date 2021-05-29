using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMedio : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Fase1-Medio");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("DificulteSelector");
    }
}
