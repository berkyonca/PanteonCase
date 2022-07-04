using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    internal class CameraBehaviour : MonoBehaviour 
    {

        [SerializeField] Transform targetPos;
        private SingletonBehaviour instance;

        private Vector3 _offSet = new Vector3(0f, 7f, -8f);


        private void Awake()
        {
         //   instance.SingletonObject(gameObject);
        }
       
        private void FixedUpdate() => CameraPosition();


        private void CameraPosition()
        {
            Vector3 _focusPos = targetPos.position + _offSet;
            transform.position = Vector3.Lerp(transform.position, _focusPos, 8 * Time.deltaTime);
        }






    }

}
