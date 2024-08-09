using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Turn{
    [Serializable]
    public class Position{
        public bool pos1;
        public bool pos2;
        public bool pos3;
        public bool pos4;
        public bool pos5;
        public bool pos6;
        public bool pos7;
    }
    public float time;
    public Position position;
    public int speed;
}
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/LevelScriptableObject", order = 1)]
public class LevelConfig : ScriptableObject
{
    public List<Turn> levelTurn;
}
