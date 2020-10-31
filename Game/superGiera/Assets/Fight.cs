using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State {START, PTURN,ETURN,WIN,LOSS }
public class Fight : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBS;
    public Transform enemyBS;

    public State fightState;
    void Start()
    {
        fightState = State.START;
        SetupFight();
    }
    void SetupFight()
    {
        Instantiate(playerPrefab, playerBS);
        Instantiate(enemyPrefab, enemyBS);
    }
}
