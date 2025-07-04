using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform cameraCenterPoint; // The target to follow
    void LateUpdate()
    {
        if (cameraCenterPoint != null)
        {
            Vector3 targetPosition = cameraCenterPoint.position;
            targetPosition.z = transform.position.z; // Maintain camera's Z offset
            transform.position = targetPosition;
        }
    }
}
