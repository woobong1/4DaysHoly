using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    [SerializeField] GameObject[] drawObj;
    Vector2 limit = new Vector2(0, 4f);
    int ranNum;
    private void Start()
    {
        ranNum = Random.Range(0, drawObj.Length);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);
    }

}