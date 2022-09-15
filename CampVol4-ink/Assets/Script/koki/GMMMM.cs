using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GMMMM : MonoBehaviour{
    [SerializeField] GameObject GCUI;
    [SerializeField] private GhostStatus status;
    [SerializeField] private GameObject ending;
    private VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer = ending.GetComponent<VideoPlayer>();
    }

    void Update(){
        //goalsの処理
        if(status.hp<=0){
            ending.SetActive(true);
            videoPlayer.Play();
            Invoke("ShowGoalUI", 10f);
        }
    }
    private void ShowGoalUI()
    {
        videoPlayer.Stop();
        GCUI.SetActive(true);
    }
}
