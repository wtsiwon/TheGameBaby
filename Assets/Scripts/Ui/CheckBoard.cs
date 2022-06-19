using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckBoard : MonoBehaviour
{
    [Header("Inspecter")]
    [SerializeField]
    private Button Nextbutton;
    [SerializeField]
    private Button Rebutton;
    
    [SerializeField]
    private GameObject animal;
    [SerializeField]
    private Canvas canvas;


    private void OnEnable()
    {
        var animal_ = animal.GetComponent<Guide>();
        GameManager.Instance.titleUp = false;
        Nextbutton.onClick.AddListener(() =>
        {
            Instantiate(animal, canvas.transform);
            GameManager.Instance.guideAnimal = animal;
            PlayerPrefs.SetInt(animal_.name,(int)animal_.eguideType);
            gameObject.SetActive(false);
            Debug.Log("È¦");
        });
        Rebutton.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            GameManager.Instance.titleUp = true;
            Debug.Log("¸®");
        });
    }
}
