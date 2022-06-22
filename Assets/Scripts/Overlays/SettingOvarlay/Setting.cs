using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    //�Ѡ���?
    private bool isset;//�ذ� �Ѡ���
    private bool isquitboard;//�����⸦ ������
    private bool issoundboard;//���带 ������
    private bool ismakerboard;//ũ������ ������

    [SerializeField]
    private Button set;//�������� ��ư���� �ִ� ��ư
    #region makers
    [SerializeField]
    private GameObject makerboard;
    [SerializeField]
    private Button makerbtn;//������
    [SerializeField]
    private Image makerimg;
    #endregion

    #region quit
    [SerializeField]
    private GameObject quitcheckboard;
    [SerializeField]
    private Button quitbtn;
    [SerializeField]
    private Image quitimg;
    #endregion

    #region sound
    [SerializeField]
    private Toggle bgmtg;
    [SerializeField]
    private Toggle sfxtg;

    [SerializeField]
    [Tooltip("���� �����Ӽ� �ִ� ����")]
    private GameObject soundsetboard;
    [SerializeField]
    private Button soundsetbtn;//�Ҹ� ���� ��ư
    [SerializeField]
    private Image soundsetimg;//������ư
    #endregion

    #region check
    [SerializeField]
    private Button cancel;
    [SerializeField]
    private Button check;
    #endregion

    #region GameObject
    [SerializeField]
    private GameObject btnsobj;//���ư��� ��ư
    [SerializeField]
    private GameObject settingboard;
    #endregion


    private void OnEnable()
    {
        //���ư��鼭 ���� �޴��� ����
        #region Onsunset
        set.onClick.AddListener(() =>
        {
            set.gameObject.SetActive(false);
            btnsobj.gameObject.SetActive(true);
            soundsetimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            makerimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            quitimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            imgRotate();
        });
        #endregion
        //������ �Ұ� 
        #region Credit
        makerbtn.onClick.AddListener(() =>
        {
            makerboard.SetActive(true);
            ismakerboard = true;
        });
        #endregion

        #region Quit
        quitbtn.onClick.AddListener(() =>
        {
            quitcheckboard.SetActive(true);
            isquitboard = true;
        });
        #endregion

        #region soundboard
        soundsetbtn.onClick.AddListener(() =>
        {
            soundsetboard.SetActive(true);
            issoundboard = true;
        });

        check.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Title");
        });
        bgmtg.onValueChanged.AddListener((ison) => { SoundManager.Instance.bgmmute = ison; });
        sfxtg.onValueChanged.AddListener((ison) => { SoundManager.Instance.sfxmute = ison; });
        #endregion

    }
    private void imgRotate()
    {
        if (isset == false)
        {
            btnsobj.transform.DORotate(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.Flash);
        }
        else
        {
            btnsobj.transform.DORotate(new Vector3(0, 0, 181), 0.5f).SetEase(Ease.Flash);
        }
    }
}
