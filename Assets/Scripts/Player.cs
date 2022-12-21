using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    PolygonCollider2D pc;

    Vector2 firstScale;
    float limitLeft = -3;
    float limitRight = 3;
    float firstY = 3.8f;
    float timer;
    int ranBoom;
    bool flagClick = false;
    bool collClick = false;
    [HideInInspector] public bool flag = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        pc = GetComponent<PolygonCollider2D>();

        rb.Sleep();
        firstScale = new Vector2(transform.localScale.x, transform.localScale.y);
        transform.localScale = transform.localScale / 2;
        StartCoroutine(ScaleSize());
        ranBoom = Random.Range(0, 4);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeadLine"))
        {
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                sr.color = Color.red;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeadLine"))
        {
            timer = 0f;
        }
    }

    void Update()
    {
        Vector2 mPosition = Input.mousePosition;
        Vector2 target = Camera.main.ScreenToWorldPoint(mPosition);

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
            if (flagClick == false)
            {
                rb.velocity = Vector2.zero;
                flagClick = true;

                StartCoroutine(ColCall());
            }
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
        yield return new WaitForSeconds(0.2f);
        transform.localScale = firstScale;
    }

    void Gameover()
    {
        Destroy(gameObject, ranBoom);
    }

    IEnumerator ColCall()
    {
        if(pc == null)
        {
            yield return new WaitForSeconds(0.15f);
            gameObject.AddComponent<PolygonCollider2D>();
        }
    }
}
