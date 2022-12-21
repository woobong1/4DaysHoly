using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField] string myTag = "";
    ObjectInit objectInit = null;

    private void Awake()
    {
        objectInit = GetComponent<ObjectInit>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(myTag))
        {
            Debug.Log("«’√º");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }        
    }    
}