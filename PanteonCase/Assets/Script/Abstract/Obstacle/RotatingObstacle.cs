using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField] [Range(0, 200)]  private float _rotateSpeed;


    private void FixedUpdate()
    {
        RotateMovement(_rotateSpeed);
    }







    private void RotateMovement(float rotateSpeed)
    {
        transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);

    }






}
