using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour {

    private static Client instance = null;
    private double startNumber = 0;
    public Text totalCount;

    private void Awake()
    {
        instance = this;
    }

    public static Client Instance()
    {
        //if (instance == null)
        //{
        //    instance = new Client();
        //}
        return instance;
    }

    public void Calculate(double number)
    {
        Operation oper;
        oper = OperationFactory.createOperate("+");
        oper.NumberA = startNumber;
        oper.NumberB = number;
        double result = oper.GetResult();
        startNumber = result;
        //totalCount.text = "111"/*result.ToString()*/;
        print(result);
    }
}
