using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpOrDown : MonoBehaviour {

    private BeadUp beadUp;
    private BeadDown beadDown;
    //toss beads number
    public int count;

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
                beadUp = transform.GetComponent<BeadUp>();
                break;
            case State.down:
                beadDown = transform.parent.GetComponent<BeadDown>();
                break;
        }
    }

    public void SendUp()
    {
        switch (state)
        {
            case State.up:
                beadUp.Up();
                break;
            case State.down:
                beadDown.Up(count);
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
                beadDown.Down(count);
                break;
        }
    }
}
