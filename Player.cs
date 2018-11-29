using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int health = 100;
    
    public GameObject deathEffect;
    public GameObject endmenu;
    
    public void TakeDamage (int damage)
    {
        health -= damage;
        
        
        if (health <= 0)
        {
            //StartCoroutine(Die());
            Die();
        }
    }
    /*IEnumerator Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        //yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }*/
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        endmenu.SetActive(true);
        Destroy(gameObject);
        
    }
}

