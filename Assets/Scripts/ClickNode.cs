using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    [SerializeField] GameObject[] drawObj;
    int ranNum;
    private void Start()
    {
 
    }


    private void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            //ranNum = Random.Range(0,ra)

            Vector2 mPosition = Input.mousePosition;
            Vector2 target = Camera.main.ScreenToWorldPoint(mPosition);
           // Instantiate(drawObj, target, Quaternion.identity);
        }
    }
}