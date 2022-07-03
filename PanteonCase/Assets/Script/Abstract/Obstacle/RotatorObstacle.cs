using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class RotatorObstacle : RotatorObstacleForce
    {
        [SerializeField] [Range(0, 400)] float _rotateSpeed;
        [SerializeField] private GameObject _parent;



        private void FixedUpdate()
        {
            ParentRotateMovement();
        }







        private void ParentRotateMovement()
        {
            _parent.transform.Rotate(Vector3.down * _rotateSpeed * Time.deltaTime);
            
        }





    }
}

