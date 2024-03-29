using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleGameManager : MonoBehaviour
{
    public enum State
    {
        START, PLAYER_TURN, ACTION, FINISH, WIN, LOSE
    }

    public State state;
    public bool isLive;

    void Awake()
    {
        state = State.START;
        BattleStart();
    }

    void BattleStart()
    {
        state =State.PLAYER_TURN;
    }

    public void PlayerTurn()
    {
        if (state != State.PLAYER_TURN)
        {
            return;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
