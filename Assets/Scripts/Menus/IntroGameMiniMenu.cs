using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroGameMiniMenu : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Comandos");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
