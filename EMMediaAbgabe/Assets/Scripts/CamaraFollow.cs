using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    private Quaternion startRotation;
    public Transform targetToMount;
    private Vector3 offset;
    public float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
        offset = transform.position - targetToMount.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offsetR = targetToMount.rotation * offset;
        Vector3 newspot = targetToMount.position + offsetR;
        transform.position = newspot;
        transform.rotation = Quaternion.Slerp(transform.rotation,
            targetToMount.rotation * startRotation, Time.deltaTime * speed);
    }
}
