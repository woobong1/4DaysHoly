using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectInit : MonoBehaviour
{
    Dictionary<string, int> cookieObject = new Dictionary<string, int>();
    int Level = 0;

    private void Awake()
    {
        CookieValueInput();
    }

    public void CookieValueInput()
    {
        cookieObject.Add("0_choco cookie", 0);
        cookieObject.Add("1_oreo cookie", 1);
        cookieObject.Add("2_macharong", 2);
        cookieObject.Add("3_heart cake", 3);
        cookieObject.Add("4_dounut", 4);
        cookieObject.Add("5_roll cake", 5);
        cookieObject.Add("6_pudding", 6);
        cookieObject.Add("7_candy corn", 7);
        cookieObject.Add("8_cheese cake", 8);
        cookieObject.Add("9_apple", 9);

        if (cookieObject.TryGetValue("9_apple", out Level))
        {
            Debug.Log(Level);
        }
    }
}
