using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay;
using UnityEngine;

public class VictoryChecker : MonoBehaviour
{
    [SerializeField] private MouseRotator rotator;
    [SerializeField] private float minAngle = 10;

    public event Action Win;
    
    void Update()
    {
        var transform = rotator.RotateTransform;
        var position = transform.position;
        
        var angle = Vector3.Angle(transform.up, Vector3.forward);
        if (angle <= minAngle)
        {
            Win?.Invoke();
            Debug.Log($"Win!");
        }
        Debug.Log($"angle {angle}");
        
        Debug.DrawRay(position, transform.forward, Color.red);
        Debug.DrawRay(position, transform.right, Color.green);
        Debug.DrawRay(position, transform.up, Color.blue);
    }

    private void OnDrawGizmos()
    {
        var transform = rotator.RotateTransform;
        var position = transform.position;
        Gizmos.color = Color.red;
        Gizmos.DrawRay(position, transform.forward);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(position, transform.forward);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(position, transform.forward);
    }
}
