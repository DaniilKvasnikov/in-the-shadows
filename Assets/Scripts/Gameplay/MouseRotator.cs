using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    [SerializeField] private float speedX = 10f;
    [SerializeField] private float speedY = 10f;
    [SerializeField] private Transform transformPoint;

    private void Update()
    {
        if (!Input.GetMouseButton(0)) return;
        float h = speedX * Input.GetAxis("Mouse X");
        float v = speedY * Input.GetAxis("Mouse Y");

        transformPoint.RotateAround(transformPoint.position, transform.transform.forward, h);
        transformPoint.RotateAround(transformPoint.position, transform.transform.right, v);
    }
}
