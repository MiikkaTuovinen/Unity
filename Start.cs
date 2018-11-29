using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {


    public void OnMouse(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void restart()
    {
        Application.LoadLevel (Application.loadedLevel);
    }
}
