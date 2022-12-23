using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource audio1 = null;
    [SerializeField] AudioSource[] audio2 = null;
    [SerializeField] Slider slider = null;
    [SerializeField] Slider slider2 = null;

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
        audio2[0].volume = slider2.value;
        audio2[1].volume = slider2.value;
        audio2[2].volume = slider2.value;
        audio2[3].volume = slider2.value;
        audio2[4].volume = slider2.value;
        audio2[5].volume = slider2.value;
        audio2[6].volume = slider2.value;
        audio2[7].volume = slider2.value;
        audio2[8].volume = slider2.value;
        audio2[9].volume = slider2.value;
        audio2[10].volume = slider2.value;
        audio2[11].volume = slider2.value;
    }
}
