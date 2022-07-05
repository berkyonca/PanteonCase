using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace PanteonCase
{
public class OpponentMovement : MonoBehaviour
{
   [SerializeField] private Transform movePositionTransform;
   private NavMeshAgent navMeshAgent;




   private void Awake()
   {
    navMeshAgent = GetComponent<NavMeshAgent>();
   }


   private void Update()
   {
    navMeshAgent.destination = movePositionTransform.transform.position;
   }










   

}

}


