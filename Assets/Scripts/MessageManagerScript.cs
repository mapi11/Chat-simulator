using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageManagerScript : MonoBehaviour
{
    public GameObject _chatPanel;
    public GameObject _textObject;

    public TMP_InputField _chatBox;

    private bool IsClick = false;


    void Update()
    {
        if(_chatBox.text == "")
        {
            IsClick = false;
        }

        if (IsClick == true)
        {
            if (_chatBox.text != "")
            {
                SendMessage(_chatBox.text);
                _chatBox.text = "";

                IsClick = false;
            }
        }
    }

    public void SendPress()
    {
        IsClick = true;
    }


    public void SendMessage(string text)
    {
        Message _newMessage = new Message();

        _newMessage._text = text;

        GameObject _newText = Instantiate(_textObject, _chatPanel.transform);

        _newMessage._textObject = _newText.GetComponent<TextMeshProUGUI>();

        _newMessage._textObject.text = _newMessage._text;

    }

    public class Message
    {
        public string _text;

        public TextMeshProUGUI _textObject;
    }
}
