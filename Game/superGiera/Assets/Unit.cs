using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Unit : MonoBehaviour
{
    public string name;
    public int level;
    public int dmg;
    public int hpMax;
    public int hpCurr;
    public float speed;
    public List<Abilities> abilities;
    public Dictionary<string, int> stats = new Dictionary<string, int>() {
        {"strength",10 },
        {"dexterity",10 },
        {"constitution",10 },
        {"wisdom",10 },
        {"intelligence",10 },
        {"charisma",10 }
    };

}
