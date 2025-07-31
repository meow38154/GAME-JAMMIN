using Irw_SO;
using UnityEngine;

namespace Irw_Button
{
    public class Door : MonoBehaviour, ButtonDawnIntercace
    {
        [SerializeField] private DoorSO doorSO;
        private SpriteRenderer spriteRenderer;
        private new Collider2D collider;

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            collider = GetComponent<Collider2D>();
            
        }

        public void ButtonDawnComplete()
        {
            spriteRenderer.sprite = doorSO.OpenSprite;
            collider.isTrigger = true;
        }

        public void ButtonUPComplete()
        {
            spriteRenderer.sprite = doorSO.CloseSprite;
            collider.isTrigger = false;
        }
    }
}

