using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    float limitLeft = -3;
    float limitRight = 3;
    float firstY = 3.8f;
    public bool flag = false;
    Vector2 firstScale;
   

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.Sleep();
        firstScale = new Vector2(transform.localScale.x, transform.localScale.y);
        transform.localScale = transform.localScale / 2;
        StartCoroutine(ScaleSize());
       
    }

    void Update()
    {
        Vector2 mPosition = Input.mousePosition;
        Vector2 target = Camera.main.ScreenToWorldPoint(mPosition);

        //this.transform.position = new Vector2(target.x, 4);

        if (flag == false)
        {
            this.transform.position = new Vector2(target.x, 4);

                if (transform.position.y >= firstY)
                {
                    if (transform.position.x <= limitLeft)
                    {
                        transform.position = new Vector2(-3, 4);
                    }

                    if (transform.position.x >= limitRight)
                    {
                        transform.position = new Vector2(3, 4);
                    }
                }
            

        }
        if (Input.GetMouseButtonDown(0))
        {
            flag = true;
            rb.WakeUp();
        }
    }

    IEnumerator ScaleSize()
    {
        yield return new WaitForSeconds(0.08f);
        transform.localScale = transform.localScale * 2.5f;
        yield return new WaitForSeconds(0.08f);
        StartCoroutine(ScaleSize2());
    }

    IEnumerator ScaleSize2()
    {
        Debug.Log("큰거왔니?");
        yield return new WaitForSeconds(0.2f);
        transform.localScale = firstScale;
    }
}
