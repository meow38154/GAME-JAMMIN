using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool type = true;

    private GoalManager goalManager;

    private void Awake()
    {
        goalManager = FindAnyObjectByType<GoalManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playermovement))
        {
            if (type == true)
            {
                goalManager.playerIn1 = true;
            }
            else
            {
                goalManager.playerIn2 = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playermovement))
        {
            if (type == true)
            {
                goalManager.playerIn1 = false;
            }
            else
            {
                goalManager.playerIn2 = false;
            }
        }
    }
}
