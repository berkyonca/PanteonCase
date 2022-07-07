using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishStructure : MonoBehaviour
{

    [SerializeField] GameObject _loseTextPanel;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "opponent")
        {
            _loseTextPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }





}
