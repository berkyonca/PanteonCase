using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanteonCase
{
    public class SingletonBehaviour : MonoBehaviour
    {
        

        public static SingletonBehaviour Instance { get; private set; }



        private void Awake()
        {
            SingletonThis();
        }

       public void SingletonThis()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }



    }
}
