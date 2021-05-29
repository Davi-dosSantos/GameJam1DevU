using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroDificil : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Fase-Dificil");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("DificultSelector");
    }
}
