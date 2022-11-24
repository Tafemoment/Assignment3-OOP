using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveHighscoreToFile : MonoBehaviour
{
   public void Save(HighscoreData data)
    {
        //convert data to json format
        string json = JsonUtility.ToJson(data);
        string path = Application.dataPath + "/Assests/highscore.txt";

        StreamWriter writer = new StreamWriter(path, false);
        writer.Write(json)
        writer.Close();
    }

    public HighscoreData Load()
    {
        try
        {
            string path = Application.dataPath + "/highscore.txt";
            StreamReader reader = new StreamReader(path);
            string fileData = reader.ReadToEnd();
            HighscoreData data = JsonUtility.FromJson<HighscoreData>(fileData);
            reader.Close();
        }
        catch (FileNotFoundException e)
        {
            Debug.LogError("No Save File " + e);
            return new HighscoreData();
        }
    }


}
