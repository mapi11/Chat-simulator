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

    [SerializeField] private GameObject InputField;

    [HideInInspector]
    public bool _isVisible;

    //public GameObject[] _delButtons;

    private void Start()
    {
        _contentChat = GameObject.Find("ContentChat");
    }
    private void Update()
    {
        //_delButtons = GameObject.FindGameObjectsWithTag("Del");
    }

    [Obsolete]
    public void DelModeOn()
    {
        _btnDelOn.SetActive(false);

        _btnSelect.SetActive(true);
        _btnSend.SetActive(false);

        InputField.SetActive(false);

        //for (int i = 0; i < _delButtons.Length; i++)
        //{
        //    //_delButtons[i].SetActiveRecursively(true);
        //}
        _isVisible = true;

        _contentChat.transform.localPosition = new Vector2(50, 350);
    }

    [Obsolete]
    public void DelModeOff()
    {
        _btnDelOn.SetActive(true);

        _btnSelect.SetActive(false);
        _btnSend.SetActive(true);

        InputField.SetActive(true);

        //for (int i = 0; i < _delButtons.Length; i++)
        //{
        //    //_delButtons[i].SetActiveRecursively(false);
        //}
        _isVisible = false;

        _contentChat.transform.localPosition = new Vector2(200, 200);
    }
}
