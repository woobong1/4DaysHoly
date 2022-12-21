using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNode : MonoBehaviour
{
    Player player;

    [SerializeField] GameObject[] drawObj;

    Vector2 limit = new Vector2(0, 4f);
    int ranNum;

    private void Start()
    {
       // player = GetComponent<Player>();
        ranNum = Random.Range(0, drawObj.Length);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);

        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if(player.flag == true)
        {
            StartCoroutine(NextDrawObj());
        }
        
    }

    IEnumerator NextDrawObj()
    {
        yield return new WaitForSeconds(1.5f);
        ranNum = Random.Range(0, drawObj.Length);
        Instantiate(drawObj[ranNum], limit, Quaternion.identity);
    }
}