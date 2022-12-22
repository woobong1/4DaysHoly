using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject[] scoreUI = null;
    [SerializeField] GameObject[] map = null;
    [SerializeField] GameObject StartGame = null;
    [SerializeField] GameObject[] startButtonObject = null;
    [SerializeField] GameObject[] optionButtonObject = null;

    [SerializeField] TextMeshProUGUI curScoreText = null;
    [SerializeField] TextMeshProUGUI highScoreText = null;
    private int savedScore = 0;
    private string KeyString = "HighScore";
    public int Score = 0;

    private void Awake()
    {
        Init();

        savedScore = PlayerPrefs.GetInt(KeyString,0);
        highScoreText.text = savedScore.ToString("0");  
    }

    void Update()
    {
        EndGame();
    }

    private void Init()
    {
        for (int i = 0; i < scoreUI.Length; i++)
        {
            scoreUI[i].SetActive(false);
        }
        for (int i = 0; i < map.Length; i++)
        {
            map[i].SetActive(false);
        }
    }

    public void GameStart()
    {
        for (int i = 0; i < scoreUI.Length; i++)
        {
            scoreUI[i].SetActive(true);
        }

        for (int i = 0; i < map.Length; i++)
        {
            map[i].SetActive(true);
        }
        StartGame.SetActive(false);

        for (int i = 0; i < startButtonObject.Length; i++)
        {
            startButtonObject[i].SetActive(false);
        }

        for (int i = 0; i < optionButtonObject.Length; i++)
        {
            optionButtonObject[i].SetActive(false);
        }
    }

    public void Restart()
    {

    }

    public void EndGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Debug.Log("게임 종료");
            Application.Quit();
#endif
        }
    }

    public void AddScore()
    {
        curScoreText.text += savedScore.ToString("0");

        if (Score > savedScore)
        {
            PlayerPrefs.SetInt(KeyString, Score);
        }
    }
}
