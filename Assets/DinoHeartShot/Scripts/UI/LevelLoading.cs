using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoading : MonoBehaviour
{
    [SerializeField] private int levelCount = 10;
    [SerializeField] private GameObject tpl;
    [SerializeField] private GameObject levelHolder;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=1;i<=levelCount;i++){
            GameObject go = Instantiate(tpl,levelHolder.transform);
            int a = i;
            Text text = go.transform.Find("LevelText").GetComponent<Text>();
            text.text = "" + a;
            go.GetComponent<Button>().onClick.AddListener(()=>{
                SceneManager.LoadScene(a+"");
            });
        }
        tpl.SetActive(false);
        gameObject.SetActive(false);
    }
}
