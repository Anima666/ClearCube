using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check_stolknovenie : MonoBehaviour {

    AudioSource au;
	void Start ()
    {
        start_pos = transform.position;
        score = 0;
        au = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();

    }

    public Vector2 start_pos;
    int xx = -10;
    public GameObject button;
    public Text text_enemy;
    int score;

    public void PlayMusic()
    {
       au.Play();
    }
    void OffButton()
    {
        button.GetComponent<Fly>().enabled = false;
        button.GetComponent<Fly>().pres = false;
        button.GetComponent<Fly>().pres2 = false;

    }
    void OnButton()
    {
        button.GetComponent<Fly>().enabled = true;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "potolok")
        {
            GetComponent<Animation>().Play();
            return;
        }
        else
        if (coll.gameObject.tag == "Finish")
        {
            SetStartPosAndIncScore();
            
            return;
        }
        else
        if (coll.gameObject.tag == "nos")
        {
            FlipPlane();
            
        }
        else
        if (coll.gameObject.tag == "plane")
        {
            SetStartPosAndIncScore();
            return;
        }


    }



    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "wall")
        {
           
            if (GetComponent<SpriteRenderer>().flipX == false)
            gameObject.transform.position = new Vector2(9.7f,transform.position.y);
            else 
            if (GetComponent<SpriteRenderer>().flipX == true)
                gameObject.transform.position = new Vector2(-9.64f, transform.position.y);

            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
           // GetComponent<Rigidbody2D>().AddForce(new Vector2(-20, 0), ForceMode2D.Impulse);
            return;
            
        }

    

       
    }

    private void SetStartPosAndIncScore()
    {
        score++;
        GetComponent<Rigidbody2D>().simulated = false;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        text_enemy.text = score.ToString();
        gameObject.transform.position = start_pos;
    }

    private void FlipPlane()
    {
        //transform.rotation= Quaternion.Euler(0, 180, 0);
        if (GetComponent<SpriteRenderer>().flipX == false)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 0), ForceMode2D.Impulse);
     
           button.GetComponent<Fly>().x = 10;
           
        }
        else
         if (GetComponent<SpriteRenderer>().flipX == true)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 0), ForceMode2D.Impulse);
            button.GetComponent<Fly>().x = -10;
            ;
        }
        
    }

     public GameObject panel;
     public GameObject gl;
    
    void Update ()
    {
        print(Time.timeScale);
        if (score>=5)
        {
            gl.GetComponent<LoadScene>().enabled = true;
            panel.SetActive(true);

            if (gameObject.name == "green")
            {
                panel.GetComponentInChildren<Text>().text = "blue";
                panel.GetComponentInChildren<Text>().color = Color.blue;
            }
            else
            {
                panel.GetComponentInChildren<Text>().color = Color.green;
                panel.GetComponentInChildren<Text>().text = "green";
            }
            Time.timeScale = 0;
            score = 0;
            return;
        }
            
        //print(GetComponent<Rigidbody2D>().velocity.y);

    }
}
