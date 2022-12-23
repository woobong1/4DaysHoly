using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    ClickNode clickNode;

    [SerializeField] string myTag = "";

    public delegate void transInfo(string str1, Vector2 vec2);
    public transInfo TransInfo = null;

    UIManager uIManager = null;  
    ObjectInit objectInit = null;

    string nextName;
    public bool isEnter = false;

    private void Awake()
    {
        if ((objectInit = FindObjectOfType<ObjectInit>()) != null)
        {
            TransInfo = objectInit.ObjectSynthetic;
        }
        uIManager = FindObjectOfType<UIManager>();
        clickNode = FindObjectOfType<ClickNode>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isEnter == true)
            return;

        if (collision.collider.CompareTag(myTag))
        {            
            if (collision.gameObject.GetComponent<Check>().isEnter == true)
            {
                Debug.Log("이미 충돌");
                return;
            }

            if (gameObject.CompareTag("9_apple")) return;

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
                isEnter = true;
            }

            else if (collision.gameObject.transform.position.y < gameObject.transform.position.y)
            {
                TransInfo(nextName, collision.gameObject.transform.position);
                SendScore(gameObject.name);
                isEnter = true;
            }

            else if (collision.gameObject.transform.position.y == gameObject.transform.position.y)
            {
                Vector2 vec2 = Vector2.zero;
                float getPosX = (transform.position.x + collision.gameObject.transform.position.x) * 0.5f;
                float getPosY = (transform.position.y + collision.gameObject.transform.position.y) * 0.5f;

                vec2 = new Vector2(getPosX, getPosY);

                TransInfo(nextName, vec2);
                SendScore(gameObject.name);
                isEnter = true;
            }

            else
            {
                Debug.Log("높이를 체크할 수 없음");
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    public void SendScore(string CookieName)
    {
        switch (CookieName)
        {
            case "0_choco cookie(Clone)":
                uIManager.ScoreAdd(1);
                break;
            case "1_oreo cookie(Clone)":
                uIManager.ScoreAdd(3);
                if (clickNode.macharong == false)
                    clickNode.macharong = true;
                break;
            case "2_macharong(Clone)":
                uIManager.ScoreAdd(9);
                if (clickNode.heartcake == false)
                    clickNode.heartcake = true;
                break;
            case "3_heart cake(Clone)":
                uIManager.ScoreAdd(27);
                if (clickNode.donut == false)
                    clickNode.donut = true;
                break;
            case "4_dounut(Clone)":
                uIManager.ScoreAdd(81);
                if (clickNode.rollcake == false)
                    clickNode.rollcake = true;
                break;
            case "5_roll cake(Clone)":
                uIManager.ScoreAdd(243);
                if (clickNode.pudding == false)
                    clickNode.pudding = true;
                break;
            case "6_pudding(Clone)":
                uIManager.ScoreAdd(729);
                if (clickNode.candyCorn == false)
                    clickNode.candyCorn = true;
                break;
            case "7_candy corn(Clone)":
                uIManager.ScoreAdd(2187);
                if (clickNode.cheesecake == false)
                    clickNode.cheesecake = true;
                break;
            case "8_cheese cake(Clone)":
                uIManager.ScoreAdd(6561);
                //if (clickNode.apple == false)
                //    clickNode.apple = true;
                break;
            case "9_apple(Clone)":
                uIManager.ScoreAdd(19683);
                break;
            default:
                Debug.Log("Score Error");
                break;
        }
    }
}