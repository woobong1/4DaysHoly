using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInit : MonoBehaviour
{
    public List<string> cookieObjectTest = new List<string>();
    [SerializeField] AudioSource[] audio = null;
    
    int ranNum;
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

    private void Update()
    {
       
    }

    public void ObjectSynthetic(string name, Vector2 position)
    {
        GameObject SyntheticObject = null;
        SyntheticObject = Instantiate(Resources.Load(name, typeof(GameObject)), position, Quaternion.identity) as GameObject;
        StartCoroutine(SoundMix());
        SyntheticObject.AddComponent<PolygonCollider2D>();
        Player pleyer = null;
        if (SyntheticObject.TryGetComponent<Player>(out pleyer) == true)
        {
            pleyer.flag = true;
        }
    }

    IEnumerator SoundMix()
    {
        ranNum = Random.Range(0, audio.Length);
        audio[ranNum].volume = 1f;
        yield return new WaitForSeconds(0.2f);
        audio[ranNum].volume = 0f;
    }
}
