using System;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class NesMono_TextFieldProFileMemory : MonoBehaviour
{

    public TMP_InputField m_inputField;
    public SaveType m_saveType = SaveType.File;
    public string m_saveUniqueId;
    public string m_defaultIfNotSet ;
    public enum SaveType
    {
        PlayerPrefs,
        File
    }

    public void Reset()
    {
        m_inputField = GetComponent<TMP_InputField>();
        m_saveUniqueId= Guid.NewGuid().ToString();
    }

    public void OnEnable()
    {
        if (m_inputField == null)
            return;
        string loadedText = "";
        switch (m_saveType)
        {
            case SaveType.PlayerPrefs:
                loadedText = PlayerPrefs.GetString(m_saveUniqueId, m_defaultIfNotSet);
                break;
            case SaveType.File:
                string path = System.IO.Path.Combine(Application.persistentDataPath, m_saveUniqueId + ".txt");
                if (System.IO.File.Exists(path))
                {
                    loadedText = System.IO.File.ReadAllText(path);
                }
                else loadedText = m_defaultIfNotSet;
                break;
        }
        m_inputField.text = loadedText;
    }

    public void OnDisable()
    {
        if (m_inputField ==null)
            return;

        string textToSave = m_inputField.text;
        switch (m_saveType)
        {
            case SaveType.PlayerPrefs:
                PlayerPrefs.SetString(m_saveUniqueId, textToSave);
                break;
            case SaveType.File:
                string path = System.IO.Path.Combine(Application.persistentDataPath, m_saveUniqueId+ ".txt");
                System.IO.File.WriteAllText(path, textToSave);
                break;
        }

    }
}

