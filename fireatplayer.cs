using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireatplayer : MonoBehaviour {

    public Transform blastpoint;
    Animator ani;
    public float targex = 1;
    public GameObject target;
    public GameObject impactEffect;
    public GameObject blastPreFab;
    //private var onetime = false;
    public bool onetime = false;

	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
		target = GameObject.FindWithTag("Player");
        
        //StartCoroutine(shoot());
        
	}
	
	// Update is called once per frame
	void Update () {
       // blastPreFab.transform.Rotate(0f, 180f, 0f);
		//Instantiate(blastPreFab, blastpoint.position, blastpoint.rotation);
        if (target.transform.position.x >= targex)
        {
            if (!onetime)
            {
            StartCoroutine(shoot());
            onetime = true;
            }
        }
        else
        {
            StopCoroutine(shoot());
        }
	}
    
    public IEnumerator shoot()
    {
        
        for(;;)
        {
            ani.Play("blast");
            Instantiate(blastPreFab, blastpoint.position, blastpoint.rotation);
            yield return new WaitForSeconds(1.5f);
            
        }
    }
}
