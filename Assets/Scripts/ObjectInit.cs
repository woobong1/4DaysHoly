using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInit : MonoBehaviour
{
    public List<string> cookieObjectTest = new List<string>();
    AudioSource audioSource = null;
    public AudioClip[] combineSound = null;
    int ranNum;

    private void Awake()
    {
        CookieValueInput();
        audioSource = GetComponent<AudioSource>();
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
        GameObject SyntheticObject = null;
        SyntheticObject = Instantiate(Resources.Load(name, typeof(GameObject)), position, Quaternion.identity) as GameObject;
        PlaySound();
        SyntheticObject.AddComponent<PolygonCollider2D>();
        Player pleyer = null;
        if (SyntheticObject.TryGetComponent<Player>(out pleyer) == true)
        {
            pleyer.flag = true;
        }
    }

    void PlaySound()
    {
        ranNum = Random.Range(0, combineSound.Length);
        audioSource.clip = combineSound[ranNum];
        audioSource.Play();
    }
}
