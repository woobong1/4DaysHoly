using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour
{
    ClickNode clickNode;
    float timer;

   [HideInInspector] public GameObject target;


    private void Start()
    {
        clickNode = FindObjectOfType<ClickNode>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("0_choco cookie") || collision.CompareTag("1_oreo cookie") ||
          collision.CompareTag("2_macharong") || collision.CompareTag("3_heart cake") ||
          collision.CompareTag("4_dounut") || collision.CompareTag("5_roll cake") ||
          collision.CompareTag("6_pudding") || collision.CompareTag("7_candy corn") ||
           collision.CompareTag("8_cheese cake") || collision.CompareTag("9_apple"))
        {
            Debug.Log("´ê¾Ò¾î!!!!!!!");

            timer += Time.deltaTime;

            if (timer > 3f)
                clickNode.gameOver = true;
        }
    }
}

