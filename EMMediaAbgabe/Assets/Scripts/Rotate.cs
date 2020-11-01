using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{    
    private void Update()
    {
        rotateObject();
    }

    private void rotateObject()
    {
        transform.Rotate(new Vector3(0f, 100f,0f) * Time.deltaTime);
    }
}



























