using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Love : MonoBehaviour
{
    [SerializeField] GameObject winPanel;
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    bool isRight;
    private Transform goal;
    private void Start(){
        goal = right;
        isRight=true;
    }
    private void Update(){
        if(transform.position.x < left.position.x && !isRight){
            goal = right;
            Flip(1);
        }else if(transform.position.x > right.position.x && isRight){
            goal = left;
            Flip(-1);
        }
        // transform.Translate((goal.position-transform.position).normalized*5*Time.deltaTime);
        transform.position += (goal == right? Vector3.right: Vector3.left) * 3 * Time.deltaTime;
    }
    private void Flip(int direction){
        transform.localScale = new Vector3(direction, 1);
        isRight = direction ==1;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Heart>()!=null){
            winPanel.SetActive(true);
            SoundManager.instance.PlayWin();
            Time.timeScale = 0;
        }
    }
}
