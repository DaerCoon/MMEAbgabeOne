using UnityEngine;
using UnityEngine.UIElements;

public class CubeMove : MonoBehaviour
{
    //private Vector3 offset;
    public float rotateSpeed = 30f;
    public float movementSpeed = 2f;


    private void Update()
    {    
        float translation = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

    }
}