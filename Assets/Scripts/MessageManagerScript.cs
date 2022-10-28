using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MessageManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject testObject;
    
    [SerializeField] private GameObject _chatPanel;

    
    [SerializeField] private GameObject _textObject;
    //[SerializeField] private GameObject _messagePanel;

    [SerializeField] private TMP_InputField _chatBox;
    
    private GameObject _a;

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


    public new void SendMessage(string Text)
    {
        Message _newMessage = new Message();

        _newMessage._text = Text;

        //Instantiate(_messagePanel, _chatPanel.transform);

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
