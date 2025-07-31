using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private bool type = true;

    private FinishManager finishManager;

    private void Awake()
    {
        finishManager = FindAnyObjectByType<FinishManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            if (type == true)
            {
                finishManager.playerIn1 = true;
            }
            else
            {
                finishManager.playerIn2 = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            if (type == true)
            {
                finishManager.playerIn1 = false;
            }
            else
            {
                finishManager.playerIn2 = false;
            }
        }
    }

}
