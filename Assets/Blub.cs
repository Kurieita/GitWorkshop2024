using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blub : MonoBehaviour
{
    // Update is called once per frame
    void Update() {
        transform.rotation *= Quaternion.Euler(0.0f, 0.0f, 360.0f * Time.deltaTime);
    }
}
