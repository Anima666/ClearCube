using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GetRandomColor : MonoBehaviour {

    public Image[] imgs;
    public GameObject grid;
    public AudioSource au;
    
    public void SetRandomImg()
    {
        GetComponent<score>().enabled = true;
        GetComponent<score>().targetTime = 10f;
        GetComponent<score>().score_count = 0;
        grid.SetActive(true);
        au.enabled = true;
        Color32 color = new Color32();
        System.Random rdn = new System.Random();
        
        for (int i = 0; i < imgs.Length; i++)
        {
            GameObject.FindGameObjectWithTag("start").GetComponent<Button>().enabled=false;
            imgs[i].enabled = true;
            imgs[i].GetComponent<BoxCollider2D>().enabled = true;
            imgs[i].GetComponent<Animation>().enabled = true;

            Color c = imgs[i].color;
            c.a = 255;
            imgs[i].color = c;
            int colorInt = rdn.Next(1, 7);
            switch (colorInt)
            {
                case 1: { color = new Color32(116, 232, 14, 255); break; }//зеленый
                case 2: { color = new Color32(237, 28, 36,255); break; }       // красный
                case 3: { color = new Color32(0, 162, 232, 255); break; }   // синий
                case 4: { color = new Color32(163, 73, 164,255); break; }// фиолетовый
                case 5: { color = new Color32(255, 242, 0, 255); break; }  // желтый
                case 6: { color = new Color32(255, 174, 201, 255); break; }// розовый
             }
            //byte r = Convert.ToByte(UnityEngine.Random.Range(0, 255));
            //byte g = Convert.ToByte(UnityEngine.Random.Range(0, 255));
            //byte b = Convert.ToByte(UnityEngine.Random.Range(0, 255));
            imgs[i].color = color;
        }
	}
	
	
}
