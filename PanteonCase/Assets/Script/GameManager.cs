using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{


    
    [SerializeField] private TextMeshProUGUI _rank1; // UI üzerinde 1. sýrada yazacak yazý.


    [SerializeField] List<GameObject> _allPlayer = new List<GameObject>(); //  Bütün Player'larýn toplandýðý yer.


    List<int> _allPlayerZPos = new List<int>();




    private void FixedUpdate()
    {


        foreach (GameObject _player in _allPlayer)
        {

            _allPlayerZPos.Add((int)_player.transform.position.z);       // _allPlayerZPos listesine rastgele bütün pozisyon deðerleri eklendi.
            _allPlayerZPos.Sort((b, a) => a.CompareTo(b));             //  _allPlayerZPos listesindeki bütün pozisyon deðerleri büyükten-küçüðe sýralandý.    =    {5,4,3,2,1}

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
















