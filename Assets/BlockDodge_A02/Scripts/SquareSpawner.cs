using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    private LevelConfig currentLevelConfig;
    // Start is called before the first frame update
    void Start()
    {
        RequestCurrentLevelConfig();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void RequestCurrentLevelConfig(){
        currentLevelConfig = GameManager.instance.CurrentLevelConfig;
    }
}
