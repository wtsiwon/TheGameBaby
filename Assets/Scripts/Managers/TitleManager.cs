using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TitleManager : Singleton<TitleManager>
{
    [Header("TitleMenu")]
    [SerializeField]
    private Image title;//�����̸�

    [SerializeField]
    private Image title2;//�������ּ���!Ÿ��Ʋ

    [SerializeField]
    private Button backGroundButton;
    

    [SerializeField]
    private Button quitbtn;
    [SerializeField]
    private GameObject quitCheck;

    private Color fadeColor;
    private Image fade;

    [SerializeField]
    private Image textMessage;

    private Tween titleTween;

    private void Start()
    {
        fadeColor = backGroundButton.GetComponent<Image>().color;
        fade = backGroundButton.GetComponent<Image>();
        quitbtn.onClick.AddListener(() =>
        {

        });

        MoveTitle();
        GoSelectGuide();
        SetResolution();
    }
    private void GoSelectGuide()//���̵� ����â���� ����
    {
        backGroundButton.onClick.AddListener(() =>
        {
            TitleMove();
        });
    }
    private void MoveTitle()//���� ����� Ÿ��Ʋ ���Ʒ��� �����̴°�
    {
        titleTween = title.transform.DOLocalMoveY(100, 2f).SetLoops(-1, LoopType.Yoyo);
    }
    private void TitleMove()//�ƹ��볪 Ŭ���� Ÿ��Ʋ �ö󰡱�
    {
        titleTween.Pause();
        textMessage.gameObject.SetActive(false);
        fadeColor.a = Mathf.Lerp(255, 0, 1.2f);//������ �������
        Invoke(nameof(FadeDisAble), 1.2f);
        title.transform.DOLocalMoveY(1000, 1.5f).SetEase(Ease.InBack);
        title2.transform.DOLocalMoveY(200, 1.5f).SetEase(Ease.InBack);
        GameManager.Instance.titleUp = true;
    }
    private void FadeDisAble()//���� �� �ٲ������ ����
    {
        fade.gameObject.SetActive(false);

    }

    public void SetResolution()//ȭ�� ���� ���߱�
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
