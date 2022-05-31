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
    private Button backGroundButton;

    private Tween titleTween;
    

    public bool selectStage;
    private bool isStart = true;

    private void Start()
    {
        MoveTitle();
        GoSelectStage();
        SetResolution();
    }
    private void GoSelectStage()
    {
        backGroundButton.onClick.AddListener(() =>
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

        backGroundButton.transform.DOLocalMoveY(-1000, 1.5f).SetEase(Ease.InBack);
        isStart = false;
    }
    public void SetResolution()
    {
        int setWidth = 1920; // ����� ���� �ʺ�
        int setHeight = 1080; // ����� ���� ����

        int deviceWidth = Screen.width; // ��� �ʺ� ����
        int deviceHeight = Screen.height; // ��� ���� ����

        Screen.SetResolution(setWidth, (int)(((float)deviceHeight / deviceWidth) * setWidth), true); // SetResolution �Լ� ����� ����ϱ�

        if ((float)setWidth / setHeight < (float)deviceWidth / deviceHeight) // ����� �ػ� �� �� ū ���
        {
            float newWidth = ((float)setWidth / setHeight) / ((float)deviceWidth / deviceHeight); // ���ο� �ʺ�
            Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f); // ���ο� Rect ����
        }
        else // ������ �ػ� �� �� ū ���
        {
            float newHeight = ((float)deviceWidth / deviceHeight) / ((float)setWidth / setHeight); // ���ο� ����
            Camera.main.rect = new Rect(0f, (1f - newHeight) / 2f, 1f, newHeight); // ���ο� Rect ����
        }
    }
}
