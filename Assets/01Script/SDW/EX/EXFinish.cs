using UnityEngine;

namespace SDW
{
    public class EXFinish : MonoBehaviour
    {
        [SerializeField] private bool type = true;
        [SerializeField] private bool type1 = true;

        private EXFinishManager EXfinishManager;

        private void Awake()
        {
            EXfinishManager = FindAnyObjectByType<EXFinishManager>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
            {
                if (type == true)
                {
                    EXfinishManager.playerIn1 = true;
                }
                else if (type1 == true)
                {
                    EXfinishManager.playerIn2 = true;
                }
                else
                {
                    EXfinishManager.playerIn3 = true;
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
            {
                if (type == true)
                {
                    EXfinishManager.playerIn1 = false;
                }
                else if (type1 == true)
                {
                    EXfinishManager.playerIn2 = false;
                }
                else
                {
                    EXfinishManager.playerIn3 = false;
                }
            }
        }

    }
}
