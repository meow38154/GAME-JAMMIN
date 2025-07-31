using System.Collections.Generic;
using Lrw_Manager;
using UnityEngine;

namespace Irw_Button
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private GameObject[] InteractionObject;
        private List<ButtonDawnIntercace> buttonDawnIntercace = new();
        [SerializeField] private LayerMask playerLayer;


        [SerializeField] private ButtonSettingSO buttonSetting;

        [UnityEngine.Range(0,100)]
        [SerializeField] private float buttonDawn;
        
        private SpriteRenderer spriteRenderer;


        private void Start()
        {

            foreach (GameObject Object in InteractionObject)
            {
                ButtonDawnIntercace a = Object.GetComponent<ButtonDawnIntercace>();
                a.ButtonUPComplete();
                buttonDawnIntercace.Add(a);
            }


            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = buttonSetting.nomalSprite;
        }

        private void Update()
        {
            PlayerCollision();
            CheckButtonDawn();
        }

        
        private void PlayerCollision()
        {
            Collider2D a = Physics2D.OverlapBox(transform.position, transform.lossyScale, 0, playerLayer);
            if (a != null)
            {
                buttonDawn += buttonSetting.buttonDawnSpeed * Time.deltaTime;
                if (buttonDawn > 100) buttonDawn = 100;
            }
            else
            {
                buttonDawn -= buttonSetting.buttonUPSpeed * Time.deltaTime;
                if (buttonDawn < 0) buttonDawn = 0;
            }

            
        }



        private void CheckButtonDawn()
        {
            if (buttonDawn >= 100)
            {
                foreach (ButtonDawnIntercace a in buttonDawnIntercace)
                {
                    a.ButtonDawnComplete();
                }
                
                spriteRenderer.sprite = buttonSetting.dawnSprite;
            }
            else if(buttonDawn <= 0)
            {
                foreach (ButtonDawnIntercace a in buttonDawnIntercace)
                {
                    a.ButtonUPComplete();
                }

                spriteRenderer.sprite = buttonSetting.nomalSprite;
            }

        }

    }
}



