using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField] Transform target;
    public float smoothSpeed;
    private Vector3 offset;
    internal static object main;

    private void Start()
    {
        offset = transform.position - target.position;
    }
    private void LateUpdate()
    {
        Vector3 desiredPos = new Vector3(0,target.transform.position.y-6,target.transform.position.z-5) + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPosition;


    }
    
}
