using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    [SerializeField] GameObject[] drawObj;

    Vector2 limit = new Vector2(0, 4f);
    int ranNum;
    bool nodeFlag = true;
    float timer;
    private void Start()
    {
        ranNum = Random.Range(0, drawObj.Length);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && nodeFlag == true)
        {
            nodeFlag = false;

            if (nodeFlag == false)
            StartCoroutine(NextDrawObj());
        }
    }

    IEnumerator NextDrawObj()
    {
        yield return new WaitForSeconds(1.5f);
        ranNum = Random.Range(0, drawObj.Length);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);
        nodeFlag = true;
    }

}