using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MessageScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txt;
    [SerializeField] private GameObject messageContent;
    [SerializeField] private TextMeshProUGUI nickname;
    [SerializeField] private Image avatar;
    [SerializeField] private TextMeshProUGUI txtTime;
    private NewMessageManagerScript nMMS;
    private void Start()
    {
        nMMS = FindObjectOfType<NewMessageManagerScript>();

        txt.text = nMMS.inputField.text;
        Instantiate(txt, messageContent.transform);
        nMMS.inputField.text = "";

        nickname.text = nMMS.pNickname;
        avatar.sprite = nMMS.pAvatar[nMMS.randInt];
        
        //Time
        DateTime time = DateTime.Now;
        string hour = LeadingZero( time.Hour);
        string minute = LeadingZero( time.Minute );
        string second = LeadingZero( time.Second );
        
        txtTime.text = hour + ":" + minute + ":" + second;
    }
    string LeadingZero (int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
