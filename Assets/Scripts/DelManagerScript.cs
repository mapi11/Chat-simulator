using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelManagerScript : MonoBehaviour
{
    public GameObject _btnDelOff;
    public GameObject _btnDelOn;

    public GameObject _btnSendOff;
    public GameObject _btnSendOn;

    public GameObject InputField;


    public void DelModeOn()
    {
        _btnDelOff.SetActive(true);
        _btnDelOn.SetActive(false);

        _btnSendOff.SetActive(true);
        _btnSendOn.SetActive(false);

        InputField.SetActive(false);
    }
    public void DelModeOff()
    {
        _btnDelOff.SetActive(false);
        _btnDelOn.SetActive(true);

        _btnSendOff.SetActive(false);
        _btnSendOn.SetActive(true);

        InputField.SetActive(true);
    }
}
