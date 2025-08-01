using Irw_SO;
using UnityEngine;

namespace SDW
{
    public class EXCoinDoor : MonoBehaviour
    {
        [SerializeField] private DoorSO doorSO;
        private SpriteRenderer spriteRenderer;
        private new Collider2D collider;
        [SerializeField] private bool coinDoor = false;
        [SerializeField] private bool coinDoorAutoOpen = false;
        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            collider = GetComponent<Collider2D>();
            ButtonUPComplete();
        }

        private void Update()
        {
            if (coinDoor && coinDoorAutoOpen)
            {
                if (EXCoinManager.instance.coinDoorOpen)
                {
                    ButtonDawnComplete();
                }
                else
                {
                    ButtonUPComplete();
                }
            }
        }

        public void ButtonDawnComplete()
        {
            if (coinDoor)
            {
                if (EXCoinManager.instance.coinDoorOpen)
                {
                    spriteRenderer.sprite = doorSO.OpenSprite;
                    collider.isTrigger = true;
                }
            }
            else
            {
                spriteRenderer.sprite = doorSO.OpenSprite;
                collider.isTrigger = true;
            }
        }

        public void ButtonUPComplete()
        {
            spriteRenderer.sprite = doorSO.CloseSprite;
            collider.isTrigger = false;
        }
    }
}

