using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] GameObject source;
    public Text resultText;

    [SerializeField ] cornNumber corn;
    public enum Result
    {
        win,
        lose
    }

    Result result;
    public void GetResult()
    {
        if(corn.totalCorn==corn.Corn)
        {
            result = Result.win;
        }
        else if(corn.totalCorn > corn.Corn)
        {
            result = Result.lose;
        }
        source.GetComponent<AudioSource>().Stop();
        gameObject.SetActive(true);
        Print();
       
    }
    void Print()
    {
        if(result==Result.win)
        {
            resultText.text = "WIN!";
        }
        else resultText.text = "LOSE!";

    }

    public void clickPlayAgain()
    {
        source.GetComponent<AudioSource>().Play();
        GameSettings.GameOver = false;
        SceneManager.LoadScene("GameScene");
    }
}
