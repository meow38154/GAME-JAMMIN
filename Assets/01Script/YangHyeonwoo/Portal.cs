using System.Collections;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform arrivalpoint;

    private PortalManager _PotalManager;

    private void Awake()
    {
        _PotalManager = GetComponentInParent<PortalManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playermovement))
        {
            if (_PotalManager.Inactive == false && _PotalManager.CoolTime == false)
            {
                collision.gameObject.transform.position = arrivalpoint.position;
                _PotalManager.Inactive = true;
                StartCoroutine(StartCooltime());
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            if (_PotalManager.Inactive == true && _PotalManager.CoolTime == false)
            {
                _PotalManager.Inactive = false;
            }
        }
    }

    IEnumerator StartCooltime()
    {
        SettingManager.Instance.PlaySound(Random.Range(4, 6));
        _PotalManager.CoolTime = true;
        yield return new WaitForSeconds(0.1f);
        _PotalManager.CoolTime = false;
    }
}
