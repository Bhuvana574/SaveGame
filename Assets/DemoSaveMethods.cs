using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoSaveMethods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.S))
        {
            SetPlayerData();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetPlayerData();
          }
    }
    void SetPlayerData()
    {
        PlayerPrefs.SetInt("Score",100);
        print("save the playerscore");
    }
    void GetPlayerData()
    {
      int score=  PlayerPrefs.GetInt("Score");
        print("The player score is " + score);
    }
}
