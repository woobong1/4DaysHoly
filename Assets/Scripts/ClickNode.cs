using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    [SerializeField] GameObject[] drawObj;
    Vector2 limit = new Vector2(0, 4f);

    public List<GameObject> prefabList = new List<GameObject>();
    public int index = 0;

    [HideInInspector] public bool nodeFlag = true;
    [HideInInspector] public bool cookie3 = false;
    [HideInInspector] public bool cookie4 = false;
    [HideInInspector] public bool cookie5 = false;
    [HideInInspector] public bool cookie6 = false;
    [HideInInspector] public bool cookie7 = false;
    [HideInInspector] public bool cookie8 = false;
    [HideInInspector] public bool gameOver = true;
    [HideInInspector] public int combineCheck = 2;

    int ranNum;

    private void Start()
    {
       //ranNum = Random.Range(0, combineCheck);
       //Instantiate(drawObj[ranNum], limit, Quaternion.identity);
    }


    private void Update()
    {
        if (gameOver == false)
        {
            Debug.Log("¤»¤» µé¾î¿È");
            if (Input.GetMouseButtonDown(0) && nodeFlag == true)
            {
                nodeFlag = false;

                if (nodeFlag == false)
                    StartCoroutine(NextDropObj());
            }
            NextCombine();
        }
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

    public void OnStartButton()
    {
        gameOver = false;
    }
}