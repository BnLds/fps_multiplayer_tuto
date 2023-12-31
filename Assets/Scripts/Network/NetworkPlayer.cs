using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class NetworkPlayer : NetworkBehaviour, IPlayerLeft
{
    public static NetworkPlayer Local { get; set; }
    public override void Spawned()
    {
        if(Object.HasInputAuthority)
        {
            Local = this;

            Debug.Log("Spawned local player");
        }
        else
        {
            Debug.Log("Spawned remote player");
        }
    }

    public void PlayerLeft(PlayerRef player)
    {
        if(Object.HasInputAuthority)
        {
            Runner.Despawn(Object);
        }
    }

    private void Start()
    {
        
    }
}
