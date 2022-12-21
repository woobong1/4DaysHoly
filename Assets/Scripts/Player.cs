using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float limitLeft = -1.8f;
    float limitRight = 1.8f;


    void Update()
    {
        Vector2 mPosition = Input.mousePosition;
        Vector2 target = Camera.main.ScreenToWorldPoint(mPosition);

        this.transform.position = new Vector2(target.x, 4);

        if(transform.position.x <= limitLeft)
        {

        }

      
    }
}
