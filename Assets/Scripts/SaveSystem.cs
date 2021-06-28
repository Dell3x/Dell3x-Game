using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public GameObject namePanel;

    private Save save = new Save();

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Save")) namePanel.SetActive(true);
        else
        {
            save = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("Save"));
            Debug.Log("Приветствую " + save.name + "\nКоличество ваших денег: " + save.money);
        }
    }


    public void CheckName(string name)
    {
        if (!string.IsNullOrEmpty(name) && name.Length > 3)
        {
            save.name = name;
            Debug.Log("Ваше имя: " + save.name);
        }
        else Debug.Log("Имя должно составлять болле 3-х символов");
    }

    public void CheckMoney(string money)
    {
        if (!string.IsNullOrEmpty(money) && money.Length > 0)
        {
            save.money = int.Parse(money);
            Debug.Log("Количество денег: " + save.money);
        }
        else Debug.Log("На вашем счету нет денег");
    }


    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("Save", JsonUtility.ToJson(save));
    }


    [Serializable]
    public class Save
    {
        public string name;
        public int money;
    }
}
