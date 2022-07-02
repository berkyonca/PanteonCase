using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    internal class CameraBehaviour : MonoBehaviour
    {
        public static CameraBehaviour camInstance;

        private void Awake() => CameraSingleton();

        // Hedef alinacak Vector3 degeri
        [SerializeField] Transform targetPos;

        // Kameranin konumlandirilacagi nokta
        private Vector3 _offSet = new Vector3(0f, 7f, -8f);



        private void FixedUpdate() => CameraPosition();


        private void CameraPosition()
        {
            Vector3 _focusPos = targetPos.position + _offSet;
            transform.position = Vector3.Lerp(transform.position, _focusPos, 5 * Time.deltaTime);
        }


        // Main Camera objesi singleton hale getirildi.
        private void CameraSingleton()
        {
            if (camInstance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                camInstance = this;
            }
        }



    }

}
