using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] GameOverPanel gop;
    public GameObject timeOBG;
    public Text timerText;
        int time = 0;
        int k = 40;
    int Time
    {
        get
        {
            return time;
        }
        set
        {
            time = value;
            if(time==46)
            {
                gop.GetResult();
                timeOBG.SetActive(false);
                GameSettings.GameOver = true;
            }
        }
    }
    private void FixedUpdate()
    {
       
        if (k == 60 && !GameSettings.GameOver)
        {
           
            if(Time<10)
            {
                timerText.text = "00:0" + Time++.ToString();
            }
            else timerText.text = "00:" + Time++.ToString();
            k = 0;
        }
         k++;
    }
    private void Start()
    {
        timerText.text = "00:0"+Time.ToString();
      
    }
}
