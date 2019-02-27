using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeadBase : MonoBehaviour {

    public int totalBeads;
    public int multiplier;
    public float magnitude;
    protected Controller ctrl;
    public AudioManager auMgr;

    void Awake()
    {
        ctrl = GameObject.Find("Controller").GetComponent<Controller>();
        auMgr = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }
}
