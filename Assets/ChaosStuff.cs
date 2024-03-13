using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosStuff : MonoBehaviour
{
    private void Update()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time), Mathf.Cos(Time.time));
    }
}
