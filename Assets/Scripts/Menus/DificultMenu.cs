using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DificultMenu : MonoBehaviour
{

    public void Facil()
    {
        PlayerControl.playerControl.SetKeysBaseSpeed(5);
        PlataformGerator.plataformGerator.SetMaxKeys(10);
        SceneManager.LoadScene("fase1-facil");
    }
    public void Medio()
    {
        PlayerControl.playerControl.SetKeysBaseSpeed(7);
        PlataformGerator.plataformGerator.SetMaxKeys(20);
        SceneManager.LoadScene("fase1");
    }
    public void Dificil()
    {
        PlayerControl.playerControl.SetKeysBaseSpeed(10);
        PlataformGerator.plataformGerator.SetMaxKeys(50);
        SceneManager.LoadScene("fase1-dificl");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
