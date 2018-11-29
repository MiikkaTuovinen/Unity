using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

	public Transform firepoint;
    
    public GameObject impactEffect;
    public GameObject bulletPreFab;
    
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}
    
    void Shoot() 
    {
       Instantiate(bulletPreFab, firepoint.position, firepoint.rotation);
    }
}
