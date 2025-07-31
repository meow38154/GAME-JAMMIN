using Lrw_Manager;
using Unity.VisualScripting;
using UnityEngine;

namespace Irw_Button
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private GameObject InteractionObject;
        private ButtonDawnIntercace buttonDawnIntercace;
        private LayerMask playerLayer;


        [SerializeField] private ButtonSettingSO buttonSetting;

        [Range(0,100)]
        [SerializeField] private float buttonDawn = 0;

        private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            playerLayer = PlayerManager.instance.playerLayer;
            buttonDawnIntercace = InteractionObject.GetComponent<ButtonDawnIntercace>();
            buttonDawnIntercace.ButtonDawnNotComplete();

            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = buttonSetting.nomalSprite;
        }


        private void FixedUpdate()
        {
            PlayerCollision();
            CheckButtonDawn();
        }

        
        private void PlayerCollision()
        {
            Collider2D a = Physics2D.OverlapBox(transform.position, transform.lossyScale, 0, playerLayer);
            if (a != null)
            {
                buttonDawn += buttonSetting.buttonDawnSpeed * Time.fixedDeltaTime;
            }
            else
            {
                buttonDawn -= buttonSetting.buttonUPSpeed * Time.fixedDeltaTime;
            }
        }



        private void CheckButtonDawn()
        {
            if (buttonDawn >= 100)
            {
                buttonDawnIntercace.ButtonDawnComplete();
                spriteRenderer.sprite = buttonSetting.dawnSprite;
            }
            else if(buttonDawn <= 0)
            {
                buttonDawnIntercace.ButtonDawnNotComplete();
                spriteRenderer.sprite = buttonSetting.nomalSprite;
            }

        }

    }
}



