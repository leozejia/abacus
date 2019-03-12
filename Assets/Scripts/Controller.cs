using System;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public event Action ResetAll;

    public Text client;

    public void Reset()
    {
        ResetAll();
        Client.GetInstance().ResetCount();
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void AppearText()
    {
        if (client.enabled == false)
            client.enabled = true;
        else
            client.enabled = false;
    }
}