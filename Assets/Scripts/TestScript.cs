using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [Obsolete]
    public void AAA()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActiveRecursively(true);
        }
    }
    [Obsolete]
    public void BBB()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActiveRecursively(false);
        }
    }
}
