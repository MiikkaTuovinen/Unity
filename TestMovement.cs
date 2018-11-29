using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour {
	
    public float moveSpeed = 10;
    public Transform firepoint;
    public Quaternion roti;
    //public Vector3 pleft = new Vector3(-0.200f, -0.3f,0f);
    //public Vector3 pright = new Vector3(0.2f,0.3f,0f);
   
	// Use this for initialization   
	void Start () {
        
        //pright = firepoint.transform.position;
        roti = firepoint.rotation;
    }
        
	
	// Update is called once per frame
	void Update () {
		Animator a = gameObject.GetComponent<Animator> ();
		a.SetBool ("right", false);
		a.SetBool ("left", false);
		a.SetBool ("down", false);
		a.SetBool ("up", false);
        a.SetBool ("fire", false);

		//		int moveX = 0;
		Vector3 move = new Vector3 (0, 0, 0);
        if (Input.GetButtonDown ("Fire1")){
            a.SetBool("fire", true);
        
           
        }

		if (Input.GetKey ("d")) {
			move.x = 1;
			a.SetBool ("right", true);

		}
		if (Input.GetKey ("a")) {
			move.x = -1;
			a.SetBool ("left", true);

		}
		if (Input.GetKey ("w")) {
			move.y = 1;
			a.SetBool ("up", true);
		}
		if (Input.GetKey ("s")) {
			move.y = -1;
			a.SetBool ("down", true);
		}
        if (Input.GetKey ("s") && Input.GetKey ("d")) {
			move.y = -1;
            move.x = 1;
			a.SetBool ("down", true);
            a.SetBool ("right", true);
		}
        if (Input.GetKey ("w") && Input.GetKey ("d")) {
			move.y = 1;
            move.x = 1;
			a.SetBool ("up", true);
            a.SetBool ("right", true);
		}
        if (Input.GetKey ("s") && Input.GetKey ("a")) {
			move.y = -1;
            move.x = -1;
			a.SetBool ("down", true);
            a.SetBool ("left", true);
		}
        if (Input.GetKey ("w") && Input.GetKey ("a")) {
			move.y = 1;
            move.x = -1;
			a.SetBool ("up", true);
            a.SetBool ("left", true);
		}
        if((a.GetBool("left") == true)&& (a.GetBool("right") == false))
        {
            checkfirerotl();
        }
        if((a.GetBool("left") == false)&& (a.GetBool("right") == true))
        {
            checkfirerotr();
        }
		Vector3 currentPos = transform.position;
        Quaternion currentrot = Quaternion.identity;
		currentPos += move * Time.deltaTime * moveSpeed;

		transform.position = currentPos;
        transform.rotation = currentrot;
	}
    void checkfirerotl()
    {
        if(roti == firepoint.rotation)
        {
            firepoint.transform.Rotate(0f, 180f, 0f);
            //firepoint.transform.position = pleft;
        }
   
    }
    void checkfirerotr()
    {
        if(roti != firepoint.rotation)
        {
            firepoint.transform.Rotate(0f, 180f, 0f);
            //firepoint.transform.position = pright;
        }
    }
}
