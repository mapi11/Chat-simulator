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
    [HideInInspector]
    public string pNickname;
    [HideInInspector]
    public int randInt;

    private void Awake()
    {
        randInt = Random.Range(0, pAvatar.Length);

        if (randInt == 0)
        {
            pNickname = "Nickname 0";
        }
        else if (randInt == 1)
        {
            pNickname = "Nickname 1";
        }
        else if (randInt == 2)
        {
            pNickname = "Nickname 2";
        }
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
