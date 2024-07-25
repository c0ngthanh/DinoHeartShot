using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject heartObject;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject temp = Instantiate(heartObject,gameObject.transform.position+new Vector3(5,5,0),Quaternion.identity);
            temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000,10));
        }
    }
}
