using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField] string myTag = "";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(myTag))
        {
            Debug.Log("´ÙÀ½²¨ ³»³ö");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}