using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BeadUp : BeadBase
{
    private bool doneBead = false;
    private Vector3 startPosition;

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
        if (doneBead == true)
        {
            transform.DOLocalMove(startPosition, 0.1f);
            doneBead = false;
        }
    }

    public void Down()
    {
        if (doneBead == false)
        {
            transform.DOLocalMoveY(transform.localPosition.y - magnitude, 0.1f);
            doneBead = true;
        }
    }

    private void ResetBead()
    {
        transform.DOLocalMove(startPosition, 0.15f);
        doneBead = false;
    }
}