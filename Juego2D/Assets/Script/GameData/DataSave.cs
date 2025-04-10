using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataSave : MonoBehaviour
{
    private static string filePath => Path.Combine(Application.persistentDataPath, "resultados.json");

    public static void GuardarJson(GameData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(filePath, json);
        Debug.Log("Datos guardados en: " + filePath);
    }
}
