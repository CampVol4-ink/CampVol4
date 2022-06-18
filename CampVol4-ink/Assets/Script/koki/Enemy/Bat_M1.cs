using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;


public class Bat_M1 : MonoBehaviour
{
    [SerializeField] private BatStatus status;
    [SerializeField] private Slider hpslider;
    [SerializeField]
    private GameObject HPUI;
    // Start is called before the first frame update
    void Start()
    {
        status.hp = 50;
        hpslider = HPUI.transform.Find("HPBar_Bat1").GetComponent<Slider>();
        hpslider.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHPValue();
        if (status.hp <= 0) {
            //　HP表示用UIを非表示にする
            HideStatusUI();
        }
    }

    public void HideStatusUI() {
        HPUI.SetActive(false);
    }
 

    public void UpdateHPValue() {
        hpslider.value = (float)status.hp/ (float)status.maxhp;
    }
}