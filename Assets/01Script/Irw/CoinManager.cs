using UnityEngine;
using UnityEngine.SceneManagement;

namespace Irw_Coin
{
    public class CoinManager : MonoBehaviour
    {
        private int coinCount = 0;
        public int CoinCount
        {
            get
            {
                return coinCount;
            }
            set
            {
                coinCount = value;
            }
        }

        private int getCoin = 0;
        public int GetCoin
        {
            get
            {
                return getCoin;
            }
            set
            {
                getCoin = value;
            }
        }
        [field:SerializeField] public LayerMask playerLayer { get; private set; }
        public bool coinDoorOpen { get; private set; }


        public static CoinManager Instance;
        private void Awake()
        {
            if (Instance != null) Destroy(gameObject);
            else Instance = this;
        }


        private void Update()
        {
            if(coinCount == getCoin)
            {
                coinDoorOpen = true;
                coinCount = 0;
                getCoin = 0;
            }
        }

        

    }
}

