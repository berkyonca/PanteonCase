using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishWallScript : MonoBehaviour
{
    private Vector3 _targetPos = new Vector3(0f, 2.86f, 473f);
    private float _transformSpeed = 2f;
    [SerializeField] private GameObject _pressInfo;

    private void OnEnable()
    {
        _pressInfo.SetActive(true);
    }


    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _targetPos, Time.deltaTime * _transformSpeed);
    }





}
