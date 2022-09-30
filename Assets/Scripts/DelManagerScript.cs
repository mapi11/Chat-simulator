using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject _btnDelOn;
    [SerializeField] private GameObject _btnSelect;
    [SerializeField] private GameObject _btnSend;

    [SerializeField] private GameObject _contentChat;
    [SerializeField] private float _contentPos;

    [SerializeField] private GameObject InputField;

    [HideInInspector]
    public bool _isVisible;

    private void Start()
    {
        _contentChat = GameObject.Find("ContentChat");
    }
    private void Update()
    {
        _contentPos = _contentChat.transform.localPosition.y;
    }

    [Obsolete]
    public void DelModeOn()
    {
        _btnDelOn.SetActive(false);

        _btnSelect.SetActive(true);
        _btnSend.SetActive(false);

        InputField.SetActive(false);


        _isVisible = true;

        _contentChat.transform.localPosition = new Vector2(50, _contentPos);
    }

    [Obsolete]
    public void DelModeOff()
    {
        _btnDelOn.SetActive(true);

        _btnSelect.SetActive(false);
        _btnSend.SetActive(true);

        InputField.SetActive(true);


        _isVisible = false;

        _contentChat.transform.localPosition = new Vector2(200, _contentPos);
    }
}
