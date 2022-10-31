using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class MessageScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txt;
    [SerializeField] private GameObject messageContent;
    [SerializeField] private TextMeshProUGUI nickname;
    [SerializeField] private Image avatar;
    private NewMessageManagerScript nMMS;


    private void Start()
    {
        nMMS = FindObjectOfType<NewMessageManagerScript>();

        txt.text = nMMS.inputField.text;
        Instantiate(txt, messageContent.transform);
        nMMS.inputField.text = "";

        nickname.text = nMMS.pNickname;
        avatar.sprite = nMMS.pAvatar[nMMS.randInt];
    }
}
