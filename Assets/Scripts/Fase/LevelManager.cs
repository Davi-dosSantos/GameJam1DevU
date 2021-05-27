using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager;
    public int keysAtual = 0;
    private bool gameOver = false;
    private bool gameWin = false;



    private float segundos;
    private int segundosToInt;
    private int minutos;

    public Text minutosText;
    public Text segundosText;
    public Text keysText;
    public GameObject gameStartPause;
    public GameObject gameOverText;
    public GameObject gameWinText;

    // Start is called before the first frame update
    void Awake()
    {
        if(levelManager == null)
        {
            levelManager = this;
        }
        else if(levelManager != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            segundos += Time.deltaTime;
            segundosToInt = (int)segundos;
            segundosText.text = segundosToInt.ToString();
        }
        /*
        if (gameOver && Input.GetKey("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }*/
        if (gameWin)
        {
            
        }
    }

    public void SetKeys()
    {
        keysAtual++;
        keysText.text = keysAtual.ToString();
    }

    public int GetKeys()
    {
        return keysAtual;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverText.SetActive(true);
    }
    public void GameWin()
    {
        gameWin= true;
        gameWinText.SetActive(true);
    }
    public void SetKeysMaxAndBaseSpeed(int Keys,int speedBase )
    {

        PlataformGerator.plataformGerator.NumKeysWin = Keys;
        PlayerControl.playerControl.speedBase = speedBase;
    }

}
