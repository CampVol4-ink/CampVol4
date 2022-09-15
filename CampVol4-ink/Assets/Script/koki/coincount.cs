using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coincount : MonoBehaviour
{
    public TextMeshProUGUI Text;
    [SerializeField] private unitychanStatus status;

    void Update()
    {
        Text.text = string.Format(""+status.star);
    }
}