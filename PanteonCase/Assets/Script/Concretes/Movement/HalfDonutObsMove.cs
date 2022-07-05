using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutObsMove : ObstacleMovement
{

    [SerializeField] [Range(0, 10)] private float moveSpeed;

     private float _xPosLeft = -.1f;
     private float _xPosRight = .134f;


    private void FixedUpdate()
    {
        HorizontalMovement(moveSpeed);
        DirectionChanger(_xPosLeft, _xPosRight);
    }


    private void OnCollisionEnter(Collision collision)
    {
        IRespawnable _respawnable = collision.gameObject.GetComponent<IRespawnable>();
        if (_respawnable != null)
        {
            _respawnable.Respawning();
            Debug.Log("�nterface �al��t�.");
        }


    }





}
