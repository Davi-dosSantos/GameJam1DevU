using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DificultMenu : MonoBehaviour
{
    
    public void Facil()
    {
        SceneManager.LoadScene("Introducao");
    }
    public void Medio()
    {
        SceneManager.LoadScene("Introducao2");
    }
    public void Dificil()
    {
        SceneManager.LoadScene("Introducao3");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("Comandos");
    }
}
