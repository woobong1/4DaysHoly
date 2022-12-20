using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    [SerializeField] GameObject[] drawObj;
    int ranNum;


    private void Update()
    {
        
       
        if (Input.GetMouseButtonDown(0))
        {
            ranNum = Random.Range(0, drawObj.Length);

            Vector2 mPosition = Input.mousePosition;
            Vector2 target = Camera.main.ScreenToWorldPoint(mPosition);
            Instantiate(drawObj[ranNum], target, Quaternion.identity);
        }
    }
}