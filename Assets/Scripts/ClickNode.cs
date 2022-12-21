using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    [SerializeField] GameObject[] drawObj;
    Vector2 limit = new Vector2(0, 4f);
    bool nodeFlag = true;
    bool cookie3 = false;
    bool cookie4 = false;
    bool cookie5 = false;
    bool cookie6 = false;
    bool cookie7 = false;
    bool cookie8 = false;
    int ranNum;
    public int combineCheck = 2;

    private void Start()
    {
        ranNum = Random.Range(0, combineCheck);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && nodeFlag == true)
        {
            nodeFlag = false;

            if (nodeFlag == false)
                StartCoroutine(NextDropObj());
        }
        NextCombine();
    }


    void NextCombine()
    {

        if (cookie3 == true && combineCheck < 2)
        {
            combineCheck += 1;
        }
        if (cookie4 == true && combineCheck < 3)
        {
            combineCheck += 1;
        }
        if (cookie5 == true && combineCheck < 4)
        {
            combineCheck += 1;
        }
        if (cookie6 == true && combineCheck < 5)
        {
            combineCheck += 1;
        }
        if (cookie7 == true && combineCheck < 6)
        {
            combineCheck += 1;
        }
        if (cookie8 == true && combineCheck < 7)
        {
            combineCheck += 1;
        }
        if (cookie8 == true && combineCheck < 8)
        {
            combineCheck += 1;
        }
    }
    IEnumerator NextDropObj()
    {
        yield return new WaitForSeconds(1.5f);
        
        ranNum = Random.Range(0, combineCheck);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);
        nodeFlag = true;
    }
}