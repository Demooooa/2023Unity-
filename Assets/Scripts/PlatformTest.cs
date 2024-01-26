using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformTest : MonoBehaviour
{
    public static PlatformTest Instance;

    private static string configPath = "Assets/Resources/config.json";
    private ConfigData configData;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // ���config.json�ļ��Ƿ���ڣ��������򴴽�������Ĭ��ֵ  
        if (!File.Exists(configPath))
        {
            configData = new ConfigData();
            configData.isVR = false; // Ĭ�Ϸ�VR����  
            SaveConfigData();
        }
        else
        {
            LoadConfigData();
        }
    }

    private void SaveConfigData()
    {
        string json = JsonUtility.ToJson(configData);
        File.WriteAllText(configPath, json);
    }

    private void LoadConfigData()
    {
        string json = File.ReadAllText(configPath);
        configData = JsonUtility.FromJson<ConfigData>(json);
        ScenceLoad();
    }


    private void ScenceLoad()
    {
        if (configData.isVR)
        {
            // ����VR����  
            SceneManager.LoadScene(1);

        }
        else
        {
            // ����PC����  
            SceneManager.LoadScene(2);
        }
    }
}

[Serializable]
public class ConfigData
{
    public bool isVR = false; // �Ƿ�ΪVR������־λ    
}
