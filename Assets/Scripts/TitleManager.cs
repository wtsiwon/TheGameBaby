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

    private Tween titleTween;
    private Tween startTween;

    public bool selectStage;
    private bool isStart = true;

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
        titleTween = title.transform.DOLocalMoveY(100, 2f).SetLoops(-1,LoopType.Yoyo);
    }
    private void TitleMove()
    {
        titleTween.Pause();
        title.transform.DOLocalMoveY(1000, 1.5f).SetEase(Ease.InBack);
        gameStart.transform.DOLocalMoveY(-1000, 1.5f).SetEase(Ease.InBack);
        isStart = false;
    }

}
