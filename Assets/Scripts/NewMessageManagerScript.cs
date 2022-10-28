using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class NewMessageManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject pMessage;
    [SerializeField] private GameObject pChat;
    public TMP_InputField _chatBox;
    
    public void SendMessage()
    {
        if (_chatBox.text != "")
        {
            Instantiate(pMessage, pChat.transform);
        }
    }
}
