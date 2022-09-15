using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clear : MonoBehaviour{
    [SerializeField] GameObject clearUI;
    [SerializeField] private GhostStatus status;

    void Update(){
        //goalsの処理
        if(status.hp<=0){
            Invoke("ShowGoalUI", 0.1f);
        }
    }
    private void ShowGoalUI()
    {
        clearUI.SetActive(true);
    }
}