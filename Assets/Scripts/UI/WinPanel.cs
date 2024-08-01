using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinPanel : MonoBehaviour
{
    [SerializeField] private Button nextBtn;
    [SerializeField] private Button restartBtn;
    [SerializeField] private Button homeBtn;
    // Start is called before the first frame update
    void Start()
    {
        nextBtn.onClick.AddListener(NextGame);
        restartBtn.onClick.AddListener(RestartLevel);
        homeBtn.onClick.AddListener(ReturnHome);
        gameObject.SetActive(false);
    }

    private void ReturnHome()
    {
        ResumeTime();
        SceneManager.LoadScene("StartScene");
    }

    private void RestartLevel()
    {
        ResumeTime();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void NextGame()
    {
        ResumeTime();
        SceneManager.LoadScene(GetNextLevel());
    }

    private string GetNextLevel()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        return sceneName == "10" ? "StartScene" : (int.Parse(sceneName)+1).ToString();
    }

    private void ResumeTime(){
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
