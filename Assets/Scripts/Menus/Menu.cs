using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string iniciar;
    public void PlayGame()
    {
        SceneManager.LoadScene(iniciar);
    }
    public void Creditos()
    {
        SceneManager.LoadScene("creditos");
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
