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

    public void SendMessage()
    {
        if (inputField.text != "")
        {
             RectTransform rt = (RectTransform)pChat.transform;
             float height = rt.rect.height;
            Instantiate(pMessage, pChat.transform);
            
           
            pChat.transform.localPosition = new Vector2(200, height - 1400);
            
            Debug.Log(height);
        }
    }
}
