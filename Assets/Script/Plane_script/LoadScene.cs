using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	public void load_scene ()
    {
      
        SceneManager.LoadScene("plane");
       
    }
	
	void Start()
    {
       
    }
	void Update ()
    {
        if (Input.GetKeyDown("return"))
        {
            load_scene();
        }
	}
}
