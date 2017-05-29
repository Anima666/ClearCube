using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public Animation anim;
	void Start ()
    {
		
	}
	
	public void ShowRecord()
    {
        GameObject.FindGameObjectWithTag("record").GetComponent<Text>().text = PlayerPrefs.GetInt("score").ToString();
        anim.Play();
    }
    public void CloseRecord()
    {
        anim.Play("close");
    }
    public void Quit ()
    {
        Application.Quit();	
	}
}
