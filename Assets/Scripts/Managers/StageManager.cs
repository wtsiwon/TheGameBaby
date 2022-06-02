using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class StageManager : MonoBehaviour
{
    [SerializeField]
    protected Button[] guideCountry;
    
    [SerializeField]
    private Button setting;

    private float scope = 0.1f;
    private void Start()
    {
       
    }
    protected abstract void OnMouseEnter();
    protected abstract void OnMouseExit();

}
