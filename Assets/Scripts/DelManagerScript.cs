using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelManagerScript : MonoBehaviour
{
    public GameObject _btnDelOn;

    public GameObject _btnSendOff;
    public GameObject _btnSendOn;

    public GameObject InputField;

    public bool _isVisible;

    //public GameObject[] _delButtons;

    private void Start()
    {
        
    }
    private void Update()
    {
        //_delButtons = GameObject.FindGameObjectsWithTag("Del");
    }

    [Obsolete]
    public void DelModeOn()
    {
        _btnDelOn.SetActive(false);

        _btnSendOff.SetActive(true);
        _btnSendOn.SetActive(false);

        InputField.SetActive(false);

        //for (int i = 0; i < _delButtons.Length; i++)
        //{
        //    //_delButtons[i].SetActiveRecursively(true);
        //}
        _isVisible = true;
    }

    [Obsolete]
    public void DelModeOff()
    {
        _btnDelOn.SetActive(true);

        _btnSendOff.SetActive(false);
        _btnSendOn.SetActive(true);

        InputField.SetActive(true);

        //for (int i = 0; i < _delButtons.Length; i++)
        //{
        //    //_delButtons[i].SetActiveRecursively(false);
        //}
        _isVisible = false;
    }
}
