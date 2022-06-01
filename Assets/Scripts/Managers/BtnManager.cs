using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnManager : SingletonDDOL<BtnManager>
{
    [SerializeField]
    private Button gameStartBtn;
    [SerializeField]
    private Button settingBtn;


    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneNumber(scene);
    }

    public void GameStart()
    {
        gameStartBtn.onClick.AddListener(() =>
        {
            
        });
    }
    public void SettingBoard()
    {
        
    }
    private int SceneNumber(Scene scene)
    {
        int scenenum = 0;
        scenenum = scene.buildIndex;
        return scenenum;
    }
}
