using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{

    public class Player : MonoBehaviour, IDamageable, ICharacterSpawn
    {

        private PlayerMovement _movement;
        private float moveBorder = 9f;
        private float _yDeathPos = -8f;



        public bool _damageTaken { get; set; } = false;
        public float xBorder => moveBorder;

        public void Awake()
        {
            _movement = new PlayerMovement(this);
        }

        private void Update()
        {
            Damage();
            CharacterRespawn(_damageTaken, _yDeathPos);

        }
        public void FixedUpdate()
        {
            _movement.PlayerMove(50f, 10f);
        }


        public void Damage()
        {
            if (_damageTaken)
            {
                _damageTaken = false;
            }
        }

        public void CharacterRespawn(bool _isDamaged, float yDeathPos)
        {
            float _yPos = transform.position.y;
            if (_isDamaged || _yPos < yDeathPos)
            {
                transform.position = new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-1f, 6f));
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

      
        




        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("obstacle"))
            {
                _damageTaken = true;
            }

        }

      
    }
}
