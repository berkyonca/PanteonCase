using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishWallPaintScript : MonoBehaviour
{
    private int counter = -1;

    private void Update()
    {

        EnablePaintObject(counter);

    }


    private void EnablePaintObject(int _counter)
    {

        if (_counter == Mathf.Clamp(_counter, 0f, 21f))
        {
            transform.GetChild(_counter).gameObject.SetActive(true);
        }


    }





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            counter++;
        }
    }



}
