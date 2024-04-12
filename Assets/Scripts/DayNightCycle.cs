using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Ran");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Ran");

        //transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, rotationSpeed);

    }
}
