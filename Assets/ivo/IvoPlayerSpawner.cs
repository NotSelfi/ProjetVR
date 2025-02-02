using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;


public class IvoPlayerSpawner : SimulationBehaviour, IPlayerJoined, INetworkObjectProvider
{
    public IvoIGetSpawnableGO PlayerPrefab;

    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer)
        {
            Runner.Spawn(PlayerPrefab.IvoGetSpawnablerGameObject(), new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}

