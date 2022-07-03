using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class HorizontalObsMove : ObstacleMovement
    {

        [SerializeField] [Range(-5, 5)] private float _xPosLeft;
        [SerializeField] [Range(-5, 5)] private float _xPosRight;





        private void FixedUpdate()
        {
            VerticalMovement(7);
            DirectionChanger(_xPosLeft, _xPosRight);


            
        }

    }






}

