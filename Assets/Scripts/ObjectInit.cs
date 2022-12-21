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
        cookieObject.Add("0_choco cookie", 1);
        cookieObject.Add("1_oreo cookie", 3);
        cookieObject.Add("2_macharong", 9);
        cookieObject.Add("3_heart cake", 27);
        cookieObject.Add("4_dounut", 81);
        cookieObject.Add("5_roll cake", 243);
        cookieObject.Add("6_pudding", 729);
        cookieObject.Add("7_candy corn", 2187);
        cookieObject.Add("8_cheese cake", 6561);
        cookieObject.Add("9_apple", 19683);

        if (cookieObject.TryGetValue("9_apple", out Level))
        {
            Debug.Log(Level);
        }
    }

    // 여기서 체크
    // 체크할때 필요한 argument 충돌체 두개의 value 비교해서
    // 두개가 같으면 충돌체 두개중 한놈의 value 다음 친구를 dictionary에서
    // 확인해서 생성
}
