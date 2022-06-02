using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class StageManager : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{

    [SerializeField]
    protected Dictionary<string, Button> guideCountry = new Dictionary<string, Button>();
    
    [SerializeField]
    private Button setting;

    private float scope = 0.1f;

    private void Start()
    {

    }
    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        
    }
    protected virtual void ButtonClick(string guidecountry)
    {
        guideCountry[guidecountry].onClick.AddListener(() =>
        {

        });
    }
    

    public virtual void OnPointerExit(PointerEventData eventData)
    {
        
    }

    
    //protected abstract void OnMouseEnter();
    //protected abstract void OnMouseExit();
}
