using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour
{
    [SerializeField] private Button resumeBtn;
    [SerializeField] private Button restartBtn;
    [SerializeField] private Button homeBtn;
    // Start is called before the first frame update
    void Start()
    {
        resumeBtn.onClick.AddListener(ResumeGame);
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

    private void ResumeGame()
    {
        ResumeTime();
    }
    private void ResumeTime(){
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
