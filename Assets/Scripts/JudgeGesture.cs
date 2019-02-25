using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeGesture : MonoBehaviour {

    private Vector3 startPosition;
    private Vector3 nowPosition;
    private float yMoveDistance;
    private bool isSelected = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount <= 0)
        {
            isSelected = false;
            return;
        }
        if (Input.touchCount >= 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                
            }
        }

        if (Input.GetTouch(0).phase == TouchPhase.Began)
            startPosition = Input.GetTouch(0).position;
        nowPosition = Input.GetTouch(0).position;
        yMoveDistance = (nowPosition - startPosition).y;
        print(yMoveDistance);
 
    }
}
