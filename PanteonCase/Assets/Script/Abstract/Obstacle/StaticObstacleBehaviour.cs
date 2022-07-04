using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObstacleBehaviour : MonoBehaviour
{


    

    private void OnCollisionEnter(Collision collision)
    {
        IRespawnable _respawnable = collision.gameObject.GetComponent<IRespawnable>();
        if (_respawnable != null)
        {
            _respawnable.Respawning();
            Debug.Log("Ýnterface Çalýþtý.");
        }


    }





}
