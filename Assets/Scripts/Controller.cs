using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public event Action ResetAll;

    public void Reset()
    {
        ResetAll();
        Client.GetInstance().ResetCount();
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}