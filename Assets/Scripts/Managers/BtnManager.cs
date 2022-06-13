using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnManager : SingletonDDOL<BtnManager>
{
    [SerializeField]
    private Button[] guideButton;
    
    private void Start()
    {
        foreach(var btn in guideButton)
        {
            btn.onClick.AddListener(() =>
            {
                
            });
        }
    }


}
