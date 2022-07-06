using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class EasyOpponentMovement : MonoBehaviour
    {
        private Rigidbody _rb;
        private float _yDeathPos = -8f;
        [SerializeField] [Range(0, 200)] float _Speed;


        public bool _damageTaken { get; set; } = false;



        public void Awake()
        {

            _rb = GetComponent<Rigidbody>();
        }

        public void FixedUpdate()
        {
            if (_rb.velocity.z < 10)
            {
                _rb.velocity += new Vector3(0f, 0f, _Speed* Time.deltaTime);
            }

        }





        public void RotatingObstacleForce()

        {
            _rb.AddForce(Vector3.right * Time.deltaTime * 1200);
        }

        public void CharacterRespawn(float yDeathPos)
        {
            float _yPos = transform.position.y;
            if (_yPos < yDeathPos)
            {
                Respawning();
            }
        }




        public void Respawning()
        {
            transform.position = new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-1f, 6f));
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("obstacle"))
            {
                Respawning();
            }
        }

    }



}


