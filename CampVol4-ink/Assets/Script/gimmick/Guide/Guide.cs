using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Resources;
using TMPro;

public class Guide : MonoBehaviour
{

    public string message;
    public GameObject messagePref;

    private GameObject canvas;
    private GameObject messageUI;
    private float fadein_x = 100;
    private float fadeout_x = 300;
    private RectTransform ex;
    

    void Start()
    {
        canvas = GameObject.Find("Canvas");
        ex = canvas.GetComponent<RectTransform>();
    }

    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (!messageUI)
            {
                // メッセージ表示用Ui生成
                float wid = ex.rect.width * 11 / 10;
                float hei = ex.rect.height * 4 / 5;
                Vector3 spawn = new Vector3(wid, hei, 0);
                messageUI = Instantiate(messagePref, spawn, Quaternion.identity) as GameObject;
                messageUI.transform.SetParent(canvas.transform, false);

                // メッセージ設定
                TextMeshProUGUI messageUIText = messageUI.transform.Find("Guide").GetComponent<TextMeshProUGUI>();
                messageUIText.text = message;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            float targetWid = ex.rect.width * 9 / 10;
            float targetHei = ex.rect.height * 4 / 5;
            Vector3 vec = new Vector3(targetWid, targetHei, 0);
            
            Vector3 targetPos = new Vector3(700, 250, 0);
            messageUI.transform.position = Vector3.MoveTowards(messageUI.transform.position, vec, Time.deltaTime * 2000);
        }
    }

    public void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (messageUI)
            {
                Destroy(messageUI);
            }
        }
    }
}