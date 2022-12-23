using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    [SerializeField] GameObject sound = null;

    private void Start()
    {
        sound.gameObject.SetActive(false);
    }

    void OnClickOption()
    {
        sound.gameObject.SetActive(true);
    }

    void OnClickSoundExit()
    {
        sound.gameObject.SetActive(false);
    }
}
