using Lrw_Manager;
using Unity.VisualScripting;
using UnityEngine;

namespace Irw_Button
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private GameObject InteractionObject;
        private LayerMask playerLayer;
        [SerializeField] private float buttonDawnSpeed = 20;
        [SerializeField] private float buttonUPSpeed = 20;
        [SerializeField]
        [Range(0,100)]
        private float buttonDawn = 0;
        private ButtonDawnIntercace buttonDawnIntercace;


        private void Awake()
        {
            playerLayer = PlayerManager.instance.playerLayer;
            buttonDawnIntercace = InteractionObject.GetComponent<ButtonDawnIntercace>();
            buttonDawnIntercace.ButtonDawnNotComplete();
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
                buttonDawn += buttonDawnSpeed * Time.fixedDeltaTime;
            }
            else
            {
                buttonDawn -= buttonUPSpeed * Time.fixedDeltaTime;
            }
        }


        private void CheckButtonDawn()
        {
            if (buttonDawn >= 100)
            {
                buttonDawnIntercace.ButtonDawnComplete();
            }
            else if(buttonDawn <= 0)
            {
                buttonDawnIntercace.ButtonDawnNotComplete();
            }

        }

    }
}



