using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    internal class CameraBehaviour : SingletonBehaviour<CameraBehaviour>
    {

        [SerializeField] Transform targetPos;


        private Vector3 _offSet = new Vector3(0f, 7f, -8f);


        private void Awake() => SingletonObject(this);

        private void FixedUpdate() => CameraPosition();


        private void CameraPosition()
        {
            Vector3 _focusPos = targetPos.position + _offSet;
            transform.position = Vector3.Lerp(transform.position, _focusPos, 5 * Time.deltaTime);
        }






    }

}
