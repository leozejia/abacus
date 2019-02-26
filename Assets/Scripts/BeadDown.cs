using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BeadDown : BeadBase
{
    private List<bool> doneBead = new List<bool>();
    private List<Vector3> startPosition = new List<Vector3>();
    private double total = 0;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            startPosition.Add(transform.GetChild(i).transform.localPosition);
            doneBead.Add(false);
        }
    }

    private void OnEnable()
    {
        ctrl.ResetAll += ResetBead;
    }

    private void OnDisable()
    {
        ctrl.ResetAll -= ResetBead;
    }

    public void Up(int number)
    {
        for (int i = 0; i < number; i++)
        {
            if (doneBead[i] == false)
            {
                transform.GetChild(i).transform.DOLocalMoveY(transform.GetChild(i).transform.localPosition.y + magnitude, 0.1f);
                doneBead[i] = true;
            }
        }
        total = 0;
        Total(number);
        Client.Instance().Calculate(total);
    }

    public void Down(int number)
    {
        for (int i = number-1; i < totalBeads; i++)
        {
            if (doneBead[i] == true)
            {
                transform.GetChild(i).transform.DOLocalMove(startPosition[i], 0.1f);
                doneBead[i] = false;
            }
        }
    }

    private void ResetBead()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).transform.DOLocalMove(startPosition[i], 0.15f);
            doneBead[i] = false;
        }
    }

    private void Total(int _number)
    {
        total = _number * Mathf.Pow(10, multiplier - 1);
    }
}
