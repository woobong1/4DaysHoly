using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectInit : MonoBehaviour
{
    public List<string> cookieObjectTest = new List<string>();
    int count = 0;

    private void Awake()
    {
        CookieValueInput();
    }

    public void CookieValueInput()
    {
        cookieObjectTest.Add("0_choco cookie");
        cookieObjectTest.Add("1_oreo cookie");
        cookieObjectTest.Add("2_macharong");
        cookieObjectTest.Add("3_heart cake");
        cookieObjectTest.Add("4_dounut");
        cookieObjectTest.Add("5_roll cake");
        cookieObjectTest.Add("6_pudding");
        cookieObjectTest.Add("7_candy corn");
        cookieObjectTest.Add("8_cheese cake");
        cookieObjectTest.Add("9_apple");
    }

    public void ObjectSynthetic(string name, Vector2 position)
    {
        count++;
        if (count == 2)
        {
            GameObject SyntheticObject = null;
            SyntheticObject = Instantiate(Resources.Load(name, typeof(GameObject)), position, Quaternion.identity) as GameObject;
            Player p = null;
            if (SyntheticObject.TryGetComponent<Player>(out p) == true)
            {
                p.flag = true;
            }
            
            Debug.Log(SyntheticObject.transform.position + " Inst");
            count = 0;
        }
    }
}
