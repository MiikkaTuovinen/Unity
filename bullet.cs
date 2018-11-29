using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    //public AudioClip shotSound;
    
   // private AudioSource source;
    //private float vol = .5f;
   // private float volHighRange = 1.0f;
    public float speed = 20f;
    public Rigidbody2D rd;
    public int damage = 20;
    public GameObject impactEffect;
	// Use this for initialization
	void Start () {
		rd.velocity = transform.right * speed;
        //source = GetComponent<AudioSource>(); 
        // source.PlayOneShot(shotSound, vol);
	}
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        
        Instantiate(impactEffect, transform.position, transform.rotation);
        
        Destroy(gameObject);
    }
	
}
