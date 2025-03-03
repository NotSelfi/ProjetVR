using UnityEngine;
using Fusion;


public class IvoPlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    //public IvoIGetSpawnableGO PlayerPrefab;
    public GameObject PlayerPrefab;


    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer)
        {
            //Runner.Spawn(PlayerPrefab.IvoGetSpawnablerGameObject(), new Vector3(0, 1, 0), Quaternion.identity);
            Runner.Spawn(PlayerPrefab, new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}

