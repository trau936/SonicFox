﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSiteControll : MonoBehaviour
{
    public LineRenderer myLine;
    public Vector3 startPoint;
    public Vector3 stopPoint;
    public Vector3[] linePoints;
    public bool laserOn;

    // Start is called before the first frame update
    void Start()
    {
        myLine = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       if(laserOn)
        {
            myLine.SetPosition(0, transform.position);
            myLine.SetPosition(1, stopPoint);
        }
    }

    public void SetStart(Vector3 point)
    {
        startPoint = point;
    }
    public void SetEnd(Vector3 point)
    {
        stopPoint = point;
    }

    public void ToggleLaser()
    {
        laserOn = !laserOn;
        myLine.enabled = laserOn;
    }
}
