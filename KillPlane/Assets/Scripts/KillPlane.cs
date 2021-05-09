using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlane : MonoBehaviour
{
    HandleResetPlayer handleReset = new HandleResetPlayer();

    private void OnTriggerEnter(Collider collision)
    {
        var player = collision.GetComponent<PlayerMover1>();
        //if (player == null)
        //    return;

        //player.ResetPlayerPosition();

        handleReset.HandleReset(player);

    }

}

public class HandleResetPlayer
{

    public void HandleReset(PlayerMover1 player)
    {
        if (PlayerIsNull(player))
            return;

        player.ResetPlayerPosition();
    }

    public bool PlayerIsNull(PlayerMover1 player)
    {
        return player == null;  
    }

}

