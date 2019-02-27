using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour {

    private static Client instance = null;

    private Client()
    {

    }

    private void Awake()
    {
        instance = this;
        totalCount = GameObject.Find("Client").GetComponent<Text>();
    }

    public static Client GetInstance()
    {
        //if (instance == null)
        //{
        //    instance = new Client();
        //}
        return instance;
    }

    private double startNumber = 0;
    private Text totalCount;

    public void Calculate(double number)
    {
        Operation oper;
        oper = OperationFactory.createOperate("+");
        oper.NumberA = startNumber;
        oper.NumberB = number;
        double result = oper.GetResult();
        startNumber = result;
        totalCount.text = result.ToString();
        //print(result);
    }

    public void ResetCount()
    {
        startNumber = 0;
        totalCount.text = startNumber.ToString();
    }
}
