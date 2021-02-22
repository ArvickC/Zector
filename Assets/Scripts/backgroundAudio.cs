using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Timers;
using UnityEngine;

public class backgroundAudio : MonoBehaviour
{

    public static int levelNumber = 1;
    public static int christmasLevelNumber = 1;
    public static int summerLevelNumber = 1;
    public static int nightLevelNumber = 1;
    public static int coinsNumber = 0;
    public static List<int> coinCollectedLevelList = new List<int>();
    public static List<string> itemsBoughtList = new List<string>();
    static Timer savetimer = new Timer(1000);

    // Use this for initialization
    void Start()
    {
        Debug.Log("Before Load");

        LoadData();

        Debug.Log("After Load");


        savetimer.Elapsed += Savetimer_Elapsed;
        savetimer.Start();
        
    }

    private void Savetimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        Debug.Log("Before Saved");
        SaveData();
        Debug.Log("Saved!");
    }


    //Play Global
    private static backgroundAudio instance = null;
    public static backgroundAudio Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End


    // Update is called once per frame
    void Update()
    {

    }

    void SaveData()
    {
        GameData data = new GameData();

        data.levelNumber = backgroundAudio.levelNumber;
        data.christmasLevelNumber = backgroundAudio.christmasLevelNumber;
        data.summerLevelNumber = backgroundAudio.summerLevelNumber;
        data.nightLevelNumber = backgroundAudio.nightLevelNumber;
        data.coinsNumber = backgroundAudio.coinsNumber;
        data.coinCollectedLevelList = backgroundAudio.coinCollectedLevelList;
        data.itemsBoughtList = backgroundAudio.itemsBoughtList;

        BinaryFormatter bf = new BinaryFormatter();
        //FileStream file = File.Create(Application.persistentDataPath + "/PlayerData.dat");
        FileStream file = File.Create("./PlayerData.dat");
        bf.Serialize(file, data);
        file.Close();
    }

    void LoadData()
    {
        //if(File.Exists(Application.persistentDataPath + "/PlayerData.dat"))
        if(File.Exists("./PlayerData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            //FileStream file = File.Open(Application.persistentDataPath + "/PlayerData.dat", FileMode.Open);
            FileStream file = File.Open("./PlayerData.dat", FileMode.Open);
            GameData data = (GameData)bf.Deserialize(file);
            file.Close();

            backgroundAudio.levelNumber = data.levelNumber;
            backgroundAudio.christmasLevelNumber = data.christmasLevelNumber;
            backgroundAudio.summerLevelNumber = data.summerLevelNumber;
            backgroundAudio.nightLevelNumber = data.nightLevelNumber;
            backgroundAudio.coinsNumber = data.coinsNumber;
            backgroundAudio.coinCollectedLevelList = data.coinCollectedLevelList;
            backgroundAudio.itemsBoughtList = data.itemsBoughtList;
        }
    }

    public static void StopTimer()
    {
        savetimer.Stop();
    }

}

[Serializable]
class GameData
{
    public int levelNumber;
    public int christmasLevelNumber;
    public int summerLevelNumber;
    public int nightLevelNumber;
    public int coinsNumber;
    public List<int> coinCollectedLevelList;
    public List<string> itemsBoughtList;
}

