using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    [SerializeField] private LevelConfig currentLevelConfig;
    [SerializeField] private Square square;
    private float currentTime;
    private List<Turn> tempTurn;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        RequestCurrentLevelConfig();
        tempTurn = new List<Turn>(currentLevelConfig.levelTurn);
    }
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (tempTurn.Count > 0)
        {
            if (currentTime > tempTurn[0].time)
            {
                SpawnTurn(tempTurn[0]);
                tempTurn.RemoveAt(0);
            }
        }
    }
    private void RequestCurrentLevelConfig()
    {
        currentLevelConfig = GameManager.instance.CurrentLevelConfig;
    }
    private void SpawnTurn(Turn turn)
    {
        if (turn.position.pos1)
        {
            SpawnSquare(-3,turn.speed);
        }
        if (turn.position.pos2)
        {
            SpawnSquare(-2,turn.speed);
        }
        if (turn.position.pos3)
        {
            SpawnSquare(-1,turn.speed);
        }
        if (turn.position.pos4)
        {
            SpawnSquare(0,turn.speed);
        }
        if (turn.position.pos5)
        {
            SpawnSquare(1,turn.speed);
        }
        if (turn.position.pos6)
        {
            SpawnSquare(2,turn.speed);
        }
        if (turn.position.pos7)
        {
            SpawnSquare(3,turn.speed);
        }
    }
    private void SpawnSquare(int pos,float speed){
        Square temp = Instantiate(square, gameObject.transform);
        temp.transform.localPosition = new Vector3(pos,0,0);
        temp.SetSpeed(speed);
    }
}
