using UnityEngine;

namespace Irw_Button
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private LayerMask playerLayer;
        [SerializeField] private float buttonDawnSpeed = 20;

        [SerializeField]
        [Range(0,100)]
        private float buttonDawn = 0;


        private void Update()
        {
            
        }

        private void FixedUpdate()
        {
             Collider2D a =  Physics2D.OverlapBox(transform.position, transform.lossyScale,0, playerLayer);
            if(a != null)
            {
                buttonDawn += buttonDawnSpeed * Time.fixedDeltaTime;
            }
        }




    }
}



