using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField] string myTag = "";

    string nextName;
    public delegate void transInfo(string str1, Vector2 vec2);
    public transInfo TransInfo = null;
    UIManager uIManager = null;

    ObjectInit objectInit = null;

    private void Awake()
    {
        if ((objectInit = FindObjectOfType<ObjectInit>()) != null)
        {
            TransInfo = objectInit.ObjectSynthetic;
        }
        uIManager = GetComponent<UIManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag(myTag))
        {
            for (int i = 0; i < objectInit.cookieObjectTest.Count; i++)
            {   
                if (myTag == objectInit.cookieObjectTest[i] && objectInit.cookieObjectTest.Count >= i + 1)
                {
                    nextName = objectInit.cookieObjectTest[i + 1];
                }
            }

            if (collision.gameObject.transform.position.y > gameObject.transform.position.y)
            {
                TransInfo(nextName, transform.position);
                SendScore(gameObject.name);
            }

            else if (collision.gameObject.transform.position.y < gameObject.transform.position.y)
            {
                TransInfo(nextName, collision.gameObject.transform.position);
                SendScore(gameObject.name);
            }

            else if (collision.gameObject.transform.position.y == gameObject.transform.position.y)
            {
                Vector2 vec2 = Vector2.zero;
                float getPosX = (transform.position.x + collision.gameObject.transform.position.x) * 0.5f;
                float getPosY = (transform.position.y + collision.gameObject.transform.position.y) * 0.5f;

                vec2 = new Vector2(getPosX, getPosY);

                TransInfo(nextName, vec2);
                SendScore(gameObject.name);
            }

            else
            {
                Debug.Log("높이를 체크할 수 없음");
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void SendScore(string CookieName)
    {
        
        switch (CookieName)
        {
            case "0_choco cookie":
                uIManager.AddScore(1);
                break;
            case "1_oreo cookie":
                uIManager.AddScore(3);
                break;
            case "2_macharong":
                uIManager.AddScore(9);
                break;
            case "3_heart cake":
                uIManager.AddScore(27);
                break;
            case "4_dounut":
                uIManager.AddScore(81);
                break;
            case "5_roll cake":
                uIManager.AddScore(243);
                break;
            case "6_pudding":
                uIManager.AddScore(729);
                break;
            case "7_candy corn":
                uIManager.AddScore(2187);
                break;
            case "8_cheese cake":
                uIManager.AddScore(6561);
                break;
            case "9_apple":
                uIManager.AddScore(19683);
                break;
            default:
                Debug.Log("Score Error");
                break;
        }
    }

}