using Irw_Button;
using UnityEngine;

namespace Irw_Coin
{
    public class Coin : MonoBehaviour
    {
        private void Start()
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
                DataManager.Instance.Coin++;
                CoinManager.instance.GetCoin++;
                DataManager.Instance
                    .PlaySound(3);
                Destroy(gameObject);
            }


        }

    }
}

