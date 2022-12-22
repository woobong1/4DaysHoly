using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource audio = null;
    float timer;
    
    private void Start()
    {
        audio.volume = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 2)
            audio.volume = timer / 2;
    }

}
