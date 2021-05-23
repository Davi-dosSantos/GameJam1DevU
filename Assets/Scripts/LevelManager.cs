using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager;
    public int keysAtual = 0;
    private bool gameOver = false;

    private float segundos;
    private int segundosToInt;
    private int minutos;

    public Text minutosText;
    public Text segundosText;
    public Text keysText;
    
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

            if(segundos >= 60)
            {
                segundos = 0;
                minutos++;
                minutosText.text = minutos.ToString();

            }
            segundosToInt = (int)segundos;
            segundosText.text = segundosToInt.ToString();
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
}
