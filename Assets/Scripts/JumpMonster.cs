using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMonster : MonoBehaviour
{
    [SerializeField] private float time =3;
    [SerializeField] private int force =4;

    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;
        if(time < 0){
            Jump();
            time = 3;
        }
    }
    private void Jump(){
        GetComponent<Rigidbody2D>().AddForce(Vector2.up*force*10000);
        GetComponent<Animator>().SetTrigger("Jump");
    }
}
