using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager;
    public int keysAtual = 0;
    public int NumKeysWin;
    public bool gamePause = false;
    public AudioSource KeySound;
    public AudioSource GameWinSound;

    private bool gameOver = false;
    private bool gameWin = false;
    private float segundos;
    private int segundosToInt;
    

    public Text maxKeysText;
    public Text segundosText;
    public Text keysText;
    public GameObject gamePauseText;
    public GameObject gameOverText;
    public GameObject gameWinText;
   


    // Start is called before the first frame update

    void Start()
    { 
        maxKeysText.text = NumKeysWin.ToString();
    }


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
        

        if (!gameOver && !gamePause && Input.GetKey(KeyCode.Escape))
        {
            GameStop();

        }
        if (!gameOver && gamePause && Input.GetKey(KeyCode.Escape))
        {
            GameContinue();

        }
        if (gameWin)
        {
            GameWin();
        }
    }

    public void SetKeys()
    {
        KeySound.Play();
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
        Time.timeScale = 1f;
    }
    public void GameWin()
    {
        gameWin= true;
        gameWinText.SetActive(true);
    }
    public void GameStop()
    {
        Time.timeScale = 0f;
        gamePause = true;
        gamePauseText.SetActive(true);
    }
    public void GameContinue()
    {
        Time.timeScale = 1f;
        gamePause = false;
        gamePauseText.SetActive(false);
    }

}
