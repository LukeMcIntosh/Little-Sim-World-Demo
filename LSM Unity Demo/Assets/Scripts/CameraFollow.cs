using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform toFollow;

    private Vector3 offset;
    private Camera myCam;

    private void Start()
    {
        offset = transform.position - toFollow.position;
        myCam = GetComponent<Camera>();
    }

    private void Update()
    {
        transform.LookAt(toFollow);
        transform.position = toFollow.position + offset;
    }

}
