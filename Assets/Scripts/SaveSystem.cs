using System;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;
    
    public GameObject namePanel;

    private Save _saveInfo = new Save();
    
    public Save SaveInfo{ get{ return _saveInfo;} set{_saveInfo = value; SaveData();}}

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Save")) namePanel.SetActive(true);
        else
        {
            _saveInfo = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("Save"));
            Debug.Log("Приветствую " + _saveInfo.name + "\nКоличество ваших денег: " + _saveInfo.money);
        }
    }


    public void CheckName(string name)
    {
        if (!string.IsNullOrEmpty(name) && name.Length > 3)
        {
            _saveInfo.name = name;
            Debug.Log("Ваше имя: " + _saveInfo.name);
        }
        else Debug.Log("Имя должно составлять болле 3-х символов");
    }

    public void CheckMoney(string money)
    {
        if (!string.IsNullOrEmpty(money) && money.Length > 0)
        {
            _saveInfo.money = int.Parse(money);
            Debug.Log("Количество денег: " + _saveInfo.money);
        }
        else Debug.Log("На вашем счету нет денег");
    }

    private void SaveData()
    {
        PlayerPrefs.SetString("Save", JsonUtility.ToJson(_saveInfo));
    }


    [Serializable]
    public class Save
    {
        public string name;
        public int money;
        public float musicSound;
        public float sfxSound;
    }
}
