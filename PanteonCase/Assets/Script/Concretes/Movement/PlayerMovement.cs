using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class PlayerMovement
    {
        private Player _player;

        private Rigidbody _rb;

        private float _moveBorder;
        public bool isFinish = false;

        public PlayerMovement(Player player)
        {
            _player = player;
            _rb = player.GetComponent<Rigidbody>();
            _moveBorder = player.xBorder;
        }

        public void PlayerMove(float _verticalSpeed, float _horizontalSpeed)
        {
            #region VerticalMovement
            if (_rb.velocity.z < 10 &&  !isFinish)
            {
                _rb.velocity += new Vector3(0f, 0f, _verticalSpeed * Time.deltaTime);
            }

            #endregion

            #region HorizontalMovement

            if (Input.GetKey(KeyCode.D) && !isFinish)
            {
                _rb.transform.Translate(new Vector3(_horizontalSpeed * Time.deltaTime, 0f, 0f));
            }
            else if (Input.GetKey(KeyCode.A) && !isFinish)
            {
                _rb.transform.Translate(new Vector3(-_horizontalSpeed * Time.deltaTime, 0f, 0f));
            }

            #endregion
            
        }

       
    }

}
