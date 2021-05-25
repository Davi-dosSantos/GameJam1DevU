using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
	public void CarregarFase1()
	{
		SceneManager.LoadScene("Fase1");
	}
}
