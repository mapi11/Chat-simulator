using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;


public class TimeScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtTime;

    void Start()
    {
        //Time

        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero( time.Minute );
        string second = LeadingZero( time.Second );
        
        
        txtTime.text = hour + ":" + minute + ":" + second;
    }
    
    string LeadingZero (int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
