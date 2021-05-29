using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroFacil : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Fase-Facil");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("DificultSelector");
    }
}
