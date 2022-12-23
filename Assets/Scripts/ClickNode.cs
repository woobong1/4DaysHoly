using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    [SerializeField] GameObject[] drawObj = null;
   
    Vector2 limit = new Vector2(0, 4f);

    public List<GameObject> prefabList = new List<GameObject>();

    int ranNum;

    [HideInInspector] public bool nodeFlag = true;
    [HideInInspector] public bool macharong = false;
    [HideInInspector] public bool heartcake  = false;
    [HideInInspector] public bool donut = false;
    [HideInInspector] public bool rollcake = false;
    [HideInInspector] public bool pudding = false;
    [HideInInspector] public bool candyCorn = false;
    [HideInInspector] public bool cheesecake = false;
    [HideInInspector] public bool apple = false;

    [HideInInspector] public bool gameOver = false;
    [HideInInspector] public bool gameStart = false;
    [HideInInspector] public int index = 0;
    [HideInInspector] public int combineCheck = 2;

  
    private void Update()
    {
        if (gameStart == true)
        {
            if (gameOver == false)
            {
                if (Input.GetMouseButtonDown(0) && nodeFlag == true)
                {
                    nodeFlag = false;

                    if (nodeFlag == false)
                    {
                        NextCombine();
                        StartCoroutine(NextDropObj());
                    }
                }
            }
        }
    }

    void NextCombine()
    {
        if (macharong == true && combineCheck < 3)
        {
            combineCheck += 1;    
        }
        if (heartcake == true && combineCheck < 4)
        {
            combineCheck += 1;       
        }
        if (donut == true && combineCheck < 5)
        {
            combineCheck += 1;          
        }
        if (rollcake == true && combineCheck < 6)
        {
            combineCheck += 1;          
        }
        if (pudding == true && combineCheck < 7)
        {
            combineCheck += 1;   
        }
        if (candyCorn == true && combineCheck < 8)
        {
            combineCheck += 1;
        }
        if (cheesecake == true && combineCheck < 9)
        {
            combineCheck += 1;
        }
        if (apple == true && combineCheck < 10)
        {
            combineCheck += 1;
        }
    }

    IEnumerator NextDropObj()
    {
        yield return new WaitForSeconds(1.25f);

        ranNum = Random.Range(0, combineCheck);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);
        nodeFlag = true;
    }

    public void OnStartButton()
    {
        gameStart = true;
    }
}