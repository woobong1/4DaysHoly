using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField] string myTag = "";
    string nextName;
    public delegate void transInfo(string str1, Vector2 vec2);
    public transInfo TransInfo = null;
    ObjectInit objectInit = null;

    private void Awake()
    {
        if ((objectInit = FindObjectOfType<ObjectInit>()) != null)
        {
            TransInfo = objectInit.ObjectSynthetic;
        }
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
            }

            else if (collision.gameObject.transform.position.y < gameObject.transform.position.y)
            {
                TransInfo(nextName, collision.gameObject.transform.position);
            }

            else if (collision.gameObject.transform.position.y == gameObject.transform.position.y)
            {
                Vector2 vec2 = Vector2.zero;
                float getPosX = (transform.position.x + collision.gameObject.transform.position.x) * 0.5f;
                float getPosY = (transform.position.y + collision.gameObject.transform.position.y) * 0.5f;

                vec2 = new Vector2(getPosX, getPosY);

                TransInfo(nextName, vec2);
            }

            else
            {
                Debug.Log("높이를 체크할 수 없음");
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}