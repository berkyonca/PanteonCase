using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{


    
    [SerializeField] private TextMeshProUGUI _rank1; // UI �zerinde 1. s�rada yazacak yaz�.


    [SerializeField] List<GameObject> _allPlayer = new List<GameObject>(); //  B�t�n Player'lar�n topland��� yer.


    List<int> _allPlayerZPos = new List<int>();




    private void FixedUpdate()
    {


        foreach (GameObject _player in _allPlayer)
        {

            _allPlayerZPos.Add((int)_player.transform.position.z);       // _allPlayerZPos listesine rastgele b�t�n pozisyon de�erleri eklendi.
            _allPlayerZPos.Sort((b, a) => a.CompareTo(b));             //  _allPlayerZPos listesindeki b�t�n pozisyon de�erleri b�y�kten-k����e s�raland�.    =    {5,4,3,2,1}

            if (_player.tag == "player" && _allPlayerZPos.Count == _allPlayer.Count + 1)
            {
                int playerRank = (int)_player.transform.position.z;
                _rank1.text = (1 + _allPlayerZPos.IndexOf(playerRank)).ToString() + ".";
            }


            if (_allPlayerZPos.Count >= _allPlayer.Count + 1)
            {
                _allPlayerZPos.Clear();
            }

        }

  
     


    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

    }





}
















