using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {

    public Rigidbody2D plane;
    public Rigidbody2D plane2;
    int count = 0;
    public bool pres = false;
    public bool pres2 = false;
    public int x;
    public int x2;
    public Vector2 start_pos;
    void Start()
    {
        pres = false;
        pres2 = false;
        Time.timeScale = 1;
        start_pos = plane.transform.position;
        x = -8;
    }
	
        
    void Update ()
    {
        if (Input.GetKeyDown("up"))
        {
            
            plane.simulated = true;
            pres = true;
        }
        if (Input.GetKeyUp("up"))
        {
            pres = false;
        }
        if (pres == true)
        {
            // plane.AddForce(new Vector2(plane.transform.position.x * 2, 0));
            plane.simulated = true;
            plane.AddForce(new Vector2(x, 0));
            plane.AddForce(new Vector2(0, 0.6f), ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown("w"))
        {
            plane2.simulated = true;
            pres2 = true;
        }
        if (Input.GetKeyUp("w"))
        {
            pres2 = false;
        }
        if (pres2 == true)
        {
           plane2.AddForce(new Vector2(x*-1, 0));
          //  plane2.transform.position = Vector3.MoveTowards(plane2.transform.position, plane2.transform.position+plane2.transform.right*2,Time.deltaTime);
            plane2.AddForce(new Vector2(0, 0.7f), ForceMode2D.Impulse);
        }

        //if (plane.transform.position.y < -4)
        //{
        //    plane.transform.position = start_pos;
        //}

    }
}
