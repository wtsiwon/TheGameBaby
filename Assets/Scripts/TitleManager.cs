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
        MoveTitle();
        GoSelectStage();
    }
    private void GoSelectStage()
    {
        gameStart.onClick.AddListener(() =>
        {
            TitleMove();
        });
    }
    private void MoveTitle()
    {
        title.transform.DOLocalMoveY(200, 1f).SetRelative().SetLoops(-1,LoopType.Yoyo);
    }
    private void TitleMove()
    {
        title.transform.DOLocalMoveY(1000, 1.5f).SetEase(Ease.InBack);
    }

}
