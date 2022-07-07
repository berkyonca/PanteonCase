using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishWallPaintScript : MonoBehaviour
{
    private int counter = -1;
    [SerializeField] private float _paintPercent = 0;
    [SerializeField] private GameObject _winTextPanel;
    [SerializeField] private GameObject _percentTextObj;
    [SerializeField] private TextMeshProUGUI _percentText;
  

    private void Update()
    {

        EnablePaintObject(counter);

    }


    private void EnablePaintObject(int _counter)
    {

        if (_counter == Mathf.Clamp(_counter, 0f, 20f))
        {
            transform.GetChild(_counter).gameObject.SetActive(true);
        }


    }





    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            counter++;
            _paintPercent = Mathf.Clamp(counter + 1, 0, 20) * 5;
            _percentTextObj.SetActive(true);
            _percentText.text = _paintPercent.ToString() + " / 100";

            if (_paintPercent == 100)
            {
                _winTextPanel.SetActive(true);
            }

        }
    }
    



}
