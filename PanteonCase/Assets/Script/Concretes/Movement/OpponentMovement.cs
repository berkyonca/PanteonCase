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


     
        private void FixedUpdate()
        {

            AITargetPos();
            CharacterFalled();
            OpponentInRotatorObstacle();


        }



        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "obstacle")
            {
                Respawning();
            }
        }



        void OpponentInRotatorObstacle()
        {

            if (transform.position.z > 352 && transform.position.z < 415)
            {
                navMeshAgent.enabled = false;
                yapayZekaAktif = false;
                if (_rb.velocity.z < 10)
                {
                    _rb.velocity += new Vector3(0f, 0f, 50 * Time.deltaTime);

                }
            }
            else
            {
                navMeshAgent.enabled = true;
                yapayZekaAktif = true;

            }

        }

        public void CharacterFalled()
        {
            if (transform.position.y < -8)
            {
                transform.position = new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-1f, 6f));
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

        public void Respawning()
        {
            transform.position = new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-1f, 6f));
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }


        public void AITargetPos()
        {
            if (yapayZekaAktif)
            {
                navMeshAgent.destination = _difficulty.targetPos;
            }
        }

    }
}


