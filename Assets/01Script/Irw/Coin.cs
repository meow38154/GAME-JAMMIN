using Irw_Button;
using UnityEngine;
using System.Collections;

namespace Irw_Coin
{
    public class Coin : MonoBehaviour
    {
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

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
                DataManager.Instance.PlaySound(3);
                _animator.SetBool("isCollected", true);
                StartCoroutine(OnCollected());
            }
        }

        private IEnumerator OnCollected()
        {
            yield return new WaitForSeconds(0.5f);
            Destroy(gameObject);
        }
    }
}

