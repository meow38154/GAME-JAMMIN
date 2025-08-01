using UnityEngine;

namespace SDW
{
    public class EXCoin : MonoBehaviour
    {
        private void Start()
        {
            EXCoinManager.instance.CoinCount++;
        }

        private void Update()
        {
            CollisionCheck();
        }


        private void CollisionCheck()
        {
            Collider2D a = Physics2D.OverlapBox(transform.position, transform.lossyScale, 0, EXCoinManager.instance.playerLayer);
            if (a != null)
            {
                EXCoinManager.instance.GetCoin++;
                DataManager.Instance.PlaySound(3);
                Destroy(gameObject);
            }
        }
    }
}

