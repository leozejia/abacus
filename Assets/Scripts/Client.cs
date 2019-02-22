using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Operation oper;
        oper = OperationFactory.createOperate("+");
        oper.NumberA = 1;
        oper.NumberB = 2;
        double result = oper.GetResult();
        print(result);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
