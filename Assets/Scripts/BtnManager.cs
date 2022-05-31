using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnManager : Singleton<BtnManager>
{
    [SerializeField]
    private Button gameStartBtn;
    [SerializeField]
    private Button settingBtn;




    public void GameStart()
    {
        gameStartBtn.onClick.AddListener(() =>
        {

        });
    }
    public void SettingBoard()
    {
        
    }
}
