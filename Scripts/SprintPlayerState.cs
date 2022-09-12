using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintPlayerState : IPlayerState
{
    Player mplayer;
    Rigidbody rbPlayer;

    public void Enter(Player player)
    {
        Debug.Log("Entering State: Sprint");
        rbPlayer = player.GetComponent<Rigidbody>();
        //rbPlayer.transform.localScale *= 2.0f;
        rbPlayer.AddForce(0, 0, 500 * Time.deltaTime, ForceMode.VelocityChange);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.W))
        {
            //rbPlayer.transform.localScale *= .5f;
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}
