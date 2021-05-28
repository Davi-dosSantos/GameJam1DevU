using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComandosMenu : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("fase1");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("Introducao");
    }
    

}
