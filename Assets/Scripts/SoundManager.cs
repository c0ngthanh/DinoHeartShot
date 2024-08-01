using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField] AudioSource theme;
    [SerializeField] AudioSource key;
    [SerializeField] AudioSource win;
    // Start is called before the first frame update
    void Start()
    {
        if(instance != null&& instance !=this){
            Destroy(gameObject);
        }else{
            instance = this;
            DontDestroyOnLoad(this);
        }
        theme.Play();
    }
    public void PlayKey(){
        key.Play();
    }
    public void PlayWin(){
        win.Play();
    }
}
