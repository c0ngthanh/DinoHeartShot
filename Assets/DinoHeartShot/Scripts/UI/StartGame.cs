using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject levelObject;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(LoadLevel);
    }

    private void LoadLevel()
    {
        gameObject.SetActive(false);
        levelObject.SetActive(true);
    }
}
