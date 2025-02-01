using Fusion;
using UnityEngine;

public class IvoRaycastAttack : NetworkBehaviour
{
    public float Damage = 10;

    public IvoPlayerMovement PlayerMovement;

    void Update()
    {
        if (HasStateAuthority == false)
        {
            return;
        }

        Ray ray = PlayerMovement.Camera.ScreenPointToRay(Input.mousePosition);
        ray.origin += PlayerMovement.Camera.transform.forward;

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red, 1f);
        }

        if (Physics.Raycast(ray.origin, ray.direction, out var hit))
        {
            if (hit.transform.TryGetComponent<IvoHealth>(out var health))
            {
                health.DealDamageRpc(Damage);
            }
        }
    }
}