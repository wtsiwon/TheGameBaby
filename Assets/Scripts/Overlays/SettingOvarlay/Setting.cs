using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    //켜졋음?
    private bool isset;//해가 켜졋냐
    private bool isquitboard;//나가기를 눌렀나
    private bool issoundboard;//사운드를 눌렀나
    private bool ismakerboard;//크래딧을 눌렀나

    [SerializeField]
    private Button set;//여러가지 버튼들이 있는 버튼
    #region makers
    [SerializeField]
    private GameObject makerboard;
    [SerializeField]
    private Button makerbtn;//제작자
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
    [Tooltip("사운드 껏다켤수 있는 보드")]
    private GameObject soundsetboard;
    [SerializeField]
    private Button soundsetbtn;//소리 설정 버튼
    [SerializeField]
    private Image soundsetimg;//설정버튼
    #endregion

    #region check
    [SerializeField]
    private Button cancel;
    [SerializeField]
    private Button check;
    #endregion

    #region GameObject
    [SerializeField]
    private GameObject btnsobj;//돌아가는 버튼
    [SerializeField]
    private GameObject settingboard;
    #endregion


    private void OnEnable()
    {
        //돌아가면서 설정 메뉴가 나옴
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
        //제작자 소개 
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
