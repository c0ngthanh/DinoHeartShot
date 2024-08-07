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
    private Animator animator;
    public float time = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // if(EventSystem.current.IsPointerOverGameObject()){
            //     return;
            // };
            if(state == PlayerState.One){
                animator.SetTrigger("Split2");
            }else if(state == PlayerState.Two){
                animator.SetTrigger("Split4");
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // if(EventSystem.current.IsPointerOverGameObject()){
            //     return;
            // };
            animator.SetTrigger("2To1");
        }
    }
    public void SetStateOne(){
        state = PlayerState.One;
    }
    public void SetStateTwo(){
        state = PlayerState.Two;
    }
    public void SetStateFour(){
        state = PlayerState.Four;
    }
}
