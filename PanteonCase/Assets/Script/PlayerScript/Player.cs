using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Player : MonoBehaviour
{

    private Rigidbody _rb;

    #region SpeedVariables
    private float _verticalSpeed = 50f;
    private float _horizontalSpeed = 10f;
    #endregion

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }



    private void PlayerMovement()
    {
        #region VerticalMovement
        if (_rb.velocity.z < 10)
        {
        _rb.velocity += new Vector3(0f, 0f, _verticalSpeed * Time.deltaTime);
        }

        #endregion

        #region YatayHareket
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
