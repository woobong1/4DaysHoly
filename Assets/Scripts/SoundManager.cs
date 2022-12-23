using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource audio1 = null;
    [SerializeField] Slider slider = null;

    bool first = false;
    float timer;

    private void Start()
    {
        audio1.volume = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (first == false)
        {
            if (timer <= 2)
                audio1.volume = timer / 4;
            first = true;
        }

        audio1.volume = slider.value;
    }
}
