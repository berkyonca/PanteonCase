using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class HorizontalObsMove : ObstacleMovement
    {

        [SerializeField] [Range(-5, 5)] private float _xPosLeft;
        [SerializeField] [Range(-5, 5)] private float _xPosRight;
        [SerializeField] [Range(0, 20)] private float _horizontalSpeed;




        private void FixedUpdate()
        {
            HorizontalMovement(_horizontalSpeed);
            DirectionChanger(_xPosLeft, _xPosRight);


            
        }

        private void OnCollisionEnter(Collision collision)
        {
            IRespawnable _respawnable = collision.gameObject.GetComponent<IRespawnable>();
            if (_respawnable != null)
            {
                _respawnable.Respawning();
        
            }


        }







    }

    




}

