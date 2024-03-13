using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosStuff : MonoBehaviour
{
    private Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position = startPos +  new Vector2(Mathf.Sin(Time.time), Mathf.Cos(Time.time));
    }
}
