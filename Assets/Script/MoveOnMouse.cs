using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveOnMouse : MonoBehaviour {

    Animation anim;
    int winpoint = 10;
    Image img;
	void Start ()
    {
        anim = GetComponent<Animation>();
        sc = GameObject.FindGameObjectWithTag("sc").GetComponent<score>();
        img = GetComponent<Image>();
	}

    score sc;
    void OnMouseEnter()
    {
        //img.enabled = false;
        anim.Play();
        sc.score_count += winpoint;
        sc.text.text = sc.score_count.ToString();
        
    }
}
