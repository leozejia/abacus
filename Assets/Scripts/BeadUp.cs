using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BeadUp : BeadBase
{
    private bool doneBead = false;
    private Vector3 startPosition;
    private double total = 0;

    // Use this for initialization
    void Start () {
        doneBead = false;
        startPosition = transform.localPosition;
    }

    private void OnEnable()
    {
        ctrl.ResetAll += ResetBead;
    }

    private void OnDisable()
    {
        ctrl.ResetAll -= ResetBead;
    }

    public void Up()
    {
        print("Up");
        if (doneBead == true)
        {
            transform.DOLocalMove(startPosition, 0.1f);
            auMgr.PlayAudio();
            doneBead = false;
        }
        Total();
        Client.GetInstance().Calculate(-total);
    }

    public void Down()
    {
        print("Down");
        if (doneBead == false)
        {
            transform.DOLocalMoveY(transform.localPosition.y - magnitude, 0.1f);
            auMgr.PlayAudio();
            doneBead = true;
        }
        Total();
        Client.GetInstance().Calculate(total);
    }

    private void ResetBead()
    {
        transform.DOLocalMove(startPosition, 0.1f);
        auMgr.PlayAudio();
        doneBead = false;
    }

    private void Total()
    {
        total = 5 * Mathf.Pow(10, multiplier - 1);
    }
}