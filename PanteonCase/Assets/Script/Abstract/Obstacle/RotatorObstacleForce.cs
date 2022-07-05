using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace PanteonCase
{
    public class RotatorObstacleForce : MonoBehaviour
    {
        [SerializeField] private float _stickPower;





        private void OnCollisionEnter(Collision collision)
        {
            IRespawnable _respawnable = collision.gameObject.GetComponent<IRespawnable>();
            if (_respawnable != null)
            {
                Rigidbody _rb = collision.gameObject.GetComponent<Rigidbody>();
                Vector3 _rotatorStickForce = collision.gameObject.transform.position - transform.position;
                _rb.AddForce(_rotatorStickForce * _stickPower, ForceMode.Impulse);
            }
            
            
            





        }

        





    }












}





