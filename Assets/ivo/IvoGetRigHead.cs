using Fusion;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class IvoGetRigHead : SimulationBehaviour, IvoIGetSpawnableGO
{
    public GameObject head;
    public GameObject IvoGetSpawnablerGameObject()
    {
        return head;
    }

}
