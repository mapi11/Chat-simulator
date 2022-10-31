using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NewMessageManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject pMessage;
    [SerializeField] private GameObject pChat;
    public TMP_InputField inputField;
    public Sprite[] pAvatar;
    public string[] pNickname;
    [HideInInspector]
    public int randInt;

    private void Awake()
    {
        randInt = Random.Range(0, pAvatar.Length);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SendMessage();
        }
    }

    public void SendMessage()
    {
        if (inputField.text != "")
        {
            Instantiate(pMessage, pChat.transform);
        }
    }
}
