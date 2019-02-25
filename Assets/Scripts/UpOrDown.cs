using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpOrDown : MonoBehaviour {

    private BeadUp beadUp;
    private BeadDown beadDown;
    public int number;

    public enum State
    {
        up,
        down
    }
    public State state;

    // Use this for initialization
    void Start () {
        
        switch (state)
        {
            case State.up:
                beadUp = transform.parent.GetComponent<BeadUp>();
                break;
            case State.down:
                beadDown = transform.GetComponent<BeadDown>();
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void SendUp()
    {
        switch (state)
        {
            case State.up:
                beadUp.Up();
                break;
            case State.down:
                beadDown.Up(number);
                break;
        }
    }

    public void SendDown()
    {
        switch (state)
        {
            case State.up:
                beadUp.Down();
                break;
            case State.down:
                beadDown.Down(number);
                break;
        }
    }
}
