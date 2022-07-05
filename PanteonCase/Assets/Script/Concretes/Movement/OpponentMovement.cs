using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace PanteonCase
{
    public class OpponentMovement : MonoBehaviour
    {

        [SerializeField] private OpponentAIScriptable _difficulty;
        private NavMeshAgent navMeshAgent;
        private Rigidbody _rb;
        private bool yapayZekaAktif = false;



        private void Awake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            _rb = GetComponent<Rigidbody>();
        }


        private void Update()
        {
            if (yapayZekaAktif)
            {
                navMeshAgent.destination = _difficulty.targetPos;
            }

            if (transform.position.y < -8)
            {
                transform.position = new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-1f, 6f));
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            OpponentInRotatorObstacle();
        }


        private void FixedUpdate()
        {


            


        }

        void OpponentInRotatorObstacle()
        {

            if (transform.position.z > 352 && transform.position.z < 415)
            {
                GetComponent<NavMeshAgent>().enabled = false;
                yapayZekaAktif = false;
                if (_rb.velocity.z < 10)
                {
                    _rb.velocity += new Vector3(0f, 0f, 50 * Time.deltaTime);

                }
            }
            else
            {
                GetComponent<NavMeshAgent>().enabled = true;
                yapayZekaAktif = true;

            }

        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.CompareTag("obstacle"))
            {
                Respawning();
            }
        }

        public void Respawning()
        {
            transform.position = new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-1f, 6f));
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }



    }
}


