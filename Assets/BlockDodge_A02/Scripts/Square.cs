using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Square : MonoBehaviour
{
    private float speed = 3;
    public void SetSpeed(float speed){
        if(speed <= 0){
            this.speed = 3;
        }else{
            this.speed = speed;
        }
    }
    private void Start(){
        GetComponent<Rigidbody2D>().velocity = Vector2.down*speed;
    }
}
