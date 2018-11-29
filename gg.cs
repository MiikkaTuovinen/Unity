using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gg : MonoBehaviour {

    public GameObject endmenu;
    
    void OnTriggerEnter2D(Collider2D win)
    {
        Debug.Log(win.name);
        if(win.tag == "Player")
        {
            endmenu.SetActive(true);
        }
    }
}
