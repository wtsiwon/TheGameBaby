using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TitleManager : Singleton<TitleManager>
{
    [Header("TitleMenu")]
    [SerializeField]
    private Image title;
    [SerializeField]
    private Button gameStart;
    
    public bool selectStage;
    

    private void Start()
    {
        
    }
    public void GoSelectStage()
    {
        
    }
    private void titleMove()
    {
        title.transform.DOMoveY(1000, 1.5f).SetEase(Ease.InBack);
    }

}
