using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
public class RotatorObstacleForce : MonoBehaviour
{
        [SerializeField] private float _stickPower;


    
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("player"))
            {
                Rigidbody _rb = collision.gameObject.GetComponent<Rigidbody>();
                Vector3 _rotatorStickForce = collision.gameObject.transform.position - transform.position;
                _rb.AddForce( _rotatorStickForce * _stickPower  , ForceMode.Impulse);
                Debug.Log("RotatorObstacle Player'a vurdu");

            }
        }












    }




}
