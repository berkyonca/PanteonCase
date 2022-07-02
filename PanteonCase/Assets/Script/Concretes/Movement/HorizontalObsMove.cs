using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class HorizontalObsMove : ObstacleMovement
    {

        [SerializeField] [Range(-150, 150)] private float _xPosLeft;
        [SerializeField] [Range(-150, 150)] private float _xPosRight;





        private void FixedUpdate()
        {
            VerticalMovement(7);
            DirectionChanger(_xPosLeft, _xPosRight);


            
        }

    }






}

