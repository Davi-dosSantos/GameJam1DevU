using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DificultMenu : MonoBehaviour
{
    
    public void Facil()
    {
        SceneManager.LoadScene("Fase1-Facil");
    }
    public void Medio()
    {
        SceneManager.LoadScene("Fase1-Medio");
    }
    public void Dificil()
    {
        SceneManager.LoadScene("Fase1-Dificil");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("Comandos");
    }
}
