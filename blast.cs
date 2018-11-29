using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast : MonoBehaviour {


    public float speed = 20f;
    public Rigidbody2D rd;
    public int damage = 20;
    public GameObject impactEffect;
	// Use this for initialization
	void Start () {
		rd.velocity = transform.right * speed;
	}
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        
        Instantiate(impactEffect, transform.position, transform.rotation);
        
        Destroy(gameObject);
    }
}
