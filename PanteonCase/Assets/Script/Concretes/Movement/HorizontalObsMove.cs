using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class HorizontalObsMove : MonoBehaviour
    {
        private float _directionChange = 1;
        private float _xPosSpeed = 5;


        private void FixedUpdate()
        {
            VerticalMovement();
        }






        private void VerticalMovement()
        {
            transform.Translate(Vector3.right * Time.deltaTime * _xPosSpeed *_directionChange);
            DirectionChanger();
        }

        private void DirectionChanger()
        {
            if (transform.position.x < -9 || transform.position.x > 9)
            {
                _directionChange *= -1;
            }
        }



    }






}

