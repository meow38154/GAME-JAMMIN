using Irw_Button;
using UnityEngine;

namespace Irw_Coin
{
    public class Coin : MonoBehaviour
    {

        private void Awake()
        {
            CoinManager.instance.CoinCount++;
        }

        private void Update()
        {
            CollisionCheck();


        }


        private void CollisionCheck()
        {
            Collider2D a = Physics2D.OverlapBox(transform.position, transform.lossyScale, 0, CoinManager.instance.playerLayer);
            if (a != null)
            {
                CoinManager.instance.GetCoin++;
                Destroy(gameObject);
            }
            else
            {
                
            }


        }

    }
}

