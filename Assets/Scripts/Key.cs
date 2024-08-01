using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Heart>()!=null){
            SoundManager.instance.PlayKey();
            gameObject.SetActive(false);
        }
    }
}
