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
    [SerializeField] private TextMeshProUGUI txtTime;
    [SerializeField] private GameObject messageContent;
    private NewMessageManagerScript nMMS;
    
    private void Start()
    {
        nMMS = FindObjectOfType<NewMessageManagerScript>();
        
        txt.text = nMMS._chatBox.text;
        Instantiate(txt, messageContent.transform);
        nMMS._chatBox.text = "";
    }
}
