using Irw_Button;
using UnityEngine;
using System.Collections;

namespace Irw_Coin
{
    public class Coin : MonoBehaviour
    {
        private Animator _animator;

        private float _speed = 5;

        private bool _onPlayer;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Start()
        {
            CoinManager.Instance.CoinCount++;
        }

        private void Update()
        {
            CollisionCheck();
        }

        private void CollisionCheck()
        {
            Collider2D a = Physics2D.OverlapBox(transform.position, transform.lossyScale, 0, CoinManager.Instance.playerLayer);
            if (a != null)
            {
                _animator.SetBool("isCollected", true);
                StartCoroutine(OnCollected());

                Vector2 dir = a.transform.position - transform.position;

                transform.position += (Vector3)dir * Time.deltaTime * _speed;

                if (!_onPlayer)
                {
                    DataManager.Instance.PlaySound(3);
                    DataManager.Instance.Coin++;
                    CoinManager.Instance.GetCoin++;

                    _onPlayer = true;
                }
            }
        }

        private IEnumerator OnCollected()
        {
            yield return new WaitForSeconds(0.25f);
            Destroy(gameObject);
        }
    }
}

