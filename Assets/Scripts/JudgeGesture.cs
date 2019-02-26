using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeGesture : MonoBehaviour {

    private Vector3 startPosition;
    private Vector3 nowPosition;
    private float yMoveDistance;
    private bool isSelected = false;
    private GameObject hitObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //if (Input.GetTouch(0).phase == TouchPhase.Began&& Physics.Raycast(ray, out hit, 100))
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit, 100))
        {
            isSelected = true;
            hitObject = hit.transform.gameObject;
            startPosition = Camera.main.WorldToScreenPoint(hit.point);
            //print("StartPosition:" + startPosition);
        }
        //nowPosition = Input.GetTouch(0).position;
        if (Input.GetMouseButton(0))
        {
            nowPosition = Input.mousePosition;
            yMoveDistance = nowPosition.y - startPosition.y;
            //print("yMoveDistance" + yMoveDistance);
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (yMoveDistance > 0)
            {
                if (hitObject != null)
                {
                    hitObject.GetComponent<UpOrDown>().SendUp();
                    hitObject = null;
                }
            }
            if (yMoveDistance < 0)
            {
                if (hitObject != null)
                {
                    hitObject.GetComponent<UpOrDown>().SendDown();
                    hitObject = null;
                }
            }
            startPosition = nowPosition;
        }

        if (startPosition == nowPosition)
        {
            return;
        }
    }
}
