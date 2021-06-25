using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization;
using System;

public class NestedDemo : MonoBehaviour
{
    string playerName = "Bhuvana";
    int playerAge = 20;
    int playerscore = 100;
    string playerlocation = "Bobbili";
    [System.Serializable]
    private class DataDemo
    {
        public string playerName;
        public int playerAge;
        public int playerscore;
        public string playerlocation;

        public DataDemo(string playerName, int playerAge, int playerscore, string playerlocation)
        {
            this.playerName = playerName;
            this.playerAge = playerAge;
            this.playerscore = playerscore;
            this.playerlocation = playerlocation;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SavePlayerData();
            print("saved");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetPlayerData();
        }
    }
    void SavePlayerData()
    {
        string filepath = Application.persistentDataPath + "/NestedDemo.file";
        FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
        BinaryFormatter bw = new BinaryFormatter();
        DataDemo dm = new DataDemo(playerName, playerAge, playerscore, playerlocation);
        bw.Serialize(fs, dm);
        fs.Close();
        //bw.Close();
    }
    void GetPlayerData()
    {
        string filepath = Application.persistentDataPath + "/NestedDemo.file";
        FileStream fs = new FileStream(filepath, FileMode.Open);
        BinaryFormatter bw = new BinaryFormatter();
        DataDemo data = bw.Deserialize(fs) as DataDemo;

        print("Name:" + data.playerName + "Age:" + data.playerAge + "score:" + data.playerscore + "location:" + playerlocation);


        fs.Close();

    }
}
