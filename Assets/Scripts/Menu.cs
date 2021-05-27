using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public string iniciar;
    public void PlayGame()
    {
        Application.LoadLevel(iniciar);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
