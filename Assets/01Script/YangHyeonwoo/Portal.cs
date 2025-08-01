using System.Collections;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform arrivalPoint;

    private PortalManager _portalManager;
    private Collider2D _collider2D;

    private void Awake()
    {
        _portalManager = GetComponentInParent<PortalManager>();
        _collider2D = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_portalManager.Cooldown) return;

        if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            collision.gameObject.transform.position = arrivalPoint.position;
            StartCoroutine(StartCooldown());
            PortalManager targetPortalManager = arrivalPoint.GetComponentInParent<PortalManager>();
            if (targetPortalManager != null)
            {
                targetPortalManager.Cooldown = true;
                StartCoroutine(ClearTargetCooldown(targetPortalManager));
            }

            DataManager.Instance.PlaySound(Random.Range(4, 6));
        }
    }

    IEnumerator StartCooldown()
    {
        _portalManager.Cooldown = true;
        yield return new WaitForSeconds(0.3f);
        _portalManager.Cooldown = false;
    }

    IEnumerator ClearTargetCooldown(PortalManager target)
    {
        yield return new WaitForSeconds(0.3f);
        target.Cooldown = false;
    }
}
