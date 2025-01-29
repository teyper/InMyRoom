using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public float rotationSpeed = 20f; // Speed of rotation
    public Vector3 rotationAxis = Vector3.up; // Axis of rotation (default is Y-axis)

    // Update is called once per frame
    void Update()
    {
        // Rotate round the origin (0, 0, 0)
        transform.RotateAround(Vector3.zero, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
