using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutObsMove : ObstacleMovement
{

    [SerializeField] [Range(0, 150)] private float moveSpeed;
    [SerializeField] [Range(-150, 150)] private float _xPosLeft;
    [SerializeField] [Range(-150, 150)] private float _xPosRight;


    private void FixedUpdate()
    {
        VerticalMovement(moveSpeed);
        DirectionChanger(_xPosLeft, _xPosRight);
    }








}
