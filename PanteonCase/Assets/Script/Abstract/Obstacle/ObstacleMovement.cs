using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float _directionChange = 1;



    public virtual void VerticalMovement(float _xPosSpeed)
    {

        transform.Translate(Vector3.right * Time.deltaTime * _xPosSpeed * _directionChange);

        

    }


    public virtual void DirectionChanger(float _xPosLeftBorder, float _xPosRightBorder)
    {
        if (transform.localPosition.x < _xPosLeftBorder || transform.localPosition.x > _xPosRightBorder)
        {
            _directionChange *= -1;
        }
    }



}
