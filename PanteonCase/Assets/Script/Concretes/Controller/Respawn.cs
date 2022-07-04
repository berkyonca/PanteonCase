using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class Respawn : MonoBehaviour
    {



        public  void Respawner(GameObject _this)
        {
            if (_this.gameObject.GetComponent<Rigidbody>() != null && _this.transform.position.y < -8f)
            {
                _this.transform.position = new Vector3(Random.Range(-3f, 3f), 0f, Random.Range(-1f, 6f));
                _this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }




    }
}