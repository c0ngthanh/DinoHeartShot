using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerState{
    One,
    Two,
    Four
}
public class A02Player : MonoBehaviour
{
    private PlayerState state = PlayerState.One;
    // private Animator animator;
    public float time = 0.2f;
    [SerializeField] private GameObject state1;
    [SerializeField] private GameObject state2;
    [SerializeField] private GameObject state4;
    private float currentTime;
    private bool wait = false;
    // Start is called before the first frame update
    void Start()
    {
        // animator = GetComponent<Animator>();
        SetActiveCustom(state1,PlayerState.One);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if(wait && currentTime <0){
            SetActiveCustom(state1,PlayerState.One);
            wait=false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            switch (state)
            {
                case PlayerState.One:
                SetActiveCustom(state2,PlayerState.Two);
                break;
                case PlayerState.Two:
                SetActiveCustom(state4,PlayerState.Four);
                wait=false;
                break;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if(state == PlayerState.Two){
                currentTime = time;
                wait=true;
            }else{
                SetActiveCustom(state1,PlayerState.One);
            }
        }
    }
    private void SetActiveCustom(GameObject go,PlayerState newstate){
        StartCoroutine(WaitForSecond(0.2f));
        state1.SetActive(false);
        state2.SetActive(false);
        state4.SetActive(false);
        go.SetActive(true);
        state = newstate;
    }
    private IEnumerator WaitForSecond(float second){
        yield return new WaitForSeconds(second);
    }
}
