using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class Movement 
    {
        Player _player;

        public Movement(Player player) => _player = player;


        public void PlayerMovement(float _verticalSpeed, float _horizontalSpeed, Rigidbody _rb)
        {
            #region VerticalMovement
            if (_rb.velocity.z < 10)
            {
                _rb.velocity += new Vector3(0f, 0f, _verticalSpeed * Time.deltaTime);
            }

            #endregion

            #region HorizontalMovement
            if (Input.GetKey(KeyCode.D))
            {
                _rb.transform.Translate(new Vector3(_horizontalSpeed * Time.deltaTime, 0f, 0f));
            }
            else if (Input.GetKey(KeyCode.A))
            {
                _rb.transform.Translate(new Vector3(-_horizontalSpeed * Time.deltaTime, 0f, 0f));
            }
            #endregion

        }





    }

}
