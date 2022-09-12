using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantPlayerState : IPlayerState
{
    Player mplayer;
    Rigidbody rbPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering State: Giant");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.transform.localScale *= 6.0f;
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.G))
        {
            rbPlayer.transform.localScale *= .167f;
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}