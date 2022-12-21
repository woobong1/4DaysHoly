using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Vector2 mPosition = Input.mousePosition;

        Vector2 target = Camera.main.ScreenToWorldPoint(mPosition);

        this.transform.position = new Vector2(0, mPosition.y);
    }
}
