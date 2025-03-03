using Fusion;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class IvoFusionXROriginActivator : NetworkBehaviour
{
    public GameObject headMesh;
    public DynamicMoveProvider dynamicMoveProvider;
    public GameObject mainCamera;
    public override void Spawned()
    {
        if (HasInputAuthority)
        {
            GetComponent<XROrigin>().enabled = true;
            mainCamera.tag = "MainCamera";
        } else
        {
            //headMesh.transform.parent = transform;
            //dynamicMoveProvider.headTransform = Camera.main.transform;
        }
    }
}
