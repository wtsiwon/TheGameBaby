using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public enum EguideType
{
    Rabbit,
    Frog,
    Cat,
    Fish,
    Parrot
}
public abstract class GuideSelect : MonoBehaviour
{
    [SerializeField]
    protected Button selectBtn;
    [SerializeField]
    protected GameObject[] animal;
    [SerializeField]
    protected SpriteRenderer Overlay;
    [SerializeField]
    protected EguideType eguideType;
    protected bool isOver;

    private Dictionary<EguideType, GameObject> animals = new Dictionary<EguideType, GameObject>();
    private void Start()
    {
        #region AddListener
        //selectBtn[0].onClick.AddListener(() =>
        //{
        //    animals.Add(EguideType.Rabbit, animal[0]);
        //});
        //selectBtn[1].onClick.AddListener(() =>
        //{
        //    animals.Add(EguideType.Frog, animal[1]);
        //});
        //selectBtn[2].onClick.AddListener(() =>
        //{
        //    animals.Add(EguideType.Cat, animal[2]);
        //});
        //selectBtn[3].onClick.AddListener(() =>
        //{
        //    animals.Add(EguideType.Fish, animal[3]);
        //});
        //selectBtn[4].onClick.AddListener(() =>
        //{
        //    animals.Add(EguideType.Parrot, animal[4]);
        //});
        #endregion
    }
    protected virtual void OnMouseEnter()
    {
        Overlay.gameObject.SetActive(true);
        selectBtn.gameObject.SetActive(true);
    }
    protected virtual void OnMouseExit()
    {
        Overlay.gameObject.SetActive(false);
        selectBtn.gameObject.SetActive(false);
    }
}