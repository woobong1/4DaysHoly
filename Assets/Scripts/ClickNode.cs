using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    [SerializeField] GameObject[] drawObj;
    Vector2 limit = new Vector2(0,4f);
    int ranNum;
    private void Start()
    {
        ranNum = Random.Range(0, drawObj.Length);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);
    }

    private void Update()
    {
        Vector2 mPosition = Input.mousePosition;
       
        Vector2 target = Camera.main.ScreenToWorldPoint(mPosition);

        drawObj[ranNum].transform.position = new Vector2(0, mPosition.y); 
            

        //if (Input.GetMouseButtonDown(0))
        //{
        //    ranNum = Random.Range(0, drawObj.Length);

        //    Instantiate(drawObj[ranNum], limit, Quaternion.identity);
        //}
    }
}