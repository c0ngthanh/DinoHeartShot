using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private PausePanel pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(PauseGame);
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.gameObject.SetActive(true);
    }
}
