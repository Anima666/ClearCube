using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class score : MonoBehaviour
{
    public Text text;
    public Text timer;
    public int score_count;
    public float targetTime;
    void Start()
    {
        targetTime = 10.0f;
    }
    void Update()
    {
        targetTime -= Time.deltaTime;
        timer.text = Math.Round(targetTime,2).ToString();
        if (targetTime <= 0.0f)
        {
            timer.text = "00:00";
            timerEnded();
            this.enabled = false;
        }

       
    }
    void timerEnded()
    {
        GameObject.FindGameObjectWithTag("start").GetComponent<Button>().enabled = true;
        int score = PlayerPrefs.GetInt("score");
        
        if (score_count>score)
        {
            PlayerPrefs.SetInt("score", score_count);
        }
        GetComponent<GetRandomColor>().au.enabled = false;
       
        GetComponent<GetRandomColor>().grid.SetActive(false);
       
    }
}
