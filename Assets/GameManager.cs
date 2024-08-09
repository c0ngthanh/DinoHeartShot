using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private LevelConfig[] levelConfig;
    [SerializeField] private LevelConfig currentLevelConfig;
    public LevelConfig CurrentLevelConfig{
        get { return currentLevelConfig; }
        set { currentLevelConfig = value; }
    }
    void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
