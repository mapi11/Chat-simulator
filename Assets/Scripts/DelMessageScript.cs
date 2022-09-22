using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelMessageScript : MonoBehaviour
{
    [SerializeField] private GameObject _message;
    [SerializeField] private GameObject _btn;

    DelManagerScript _managerScript;

    private void Start()
    {
        _managerScript = FindObjectOfType<DelManagerScript>();
    }

    public void DelMessage()
    {
        Destroy(_message);
    }

    private void Update()
    {
        if (_managerScript._isVisible == true)
        {
            _btn.SetActive(true);
        }
        else
        {
            _btn.SetActive(false);
        }

    }
}
