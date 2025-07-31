using UnityEngine;

namespace Lrw_Manager
{
    public class PlayerManager : MonoBehaviour
    {

        [field:SerializeField] public LayerMask playerLayer { get; private set; }
        [field: SerializeField] public GameObject player { get; private set; }


        public static PlayerManager instance;


        private void Awake()
        {
            if (instance != null) Destroy(gameObject);
            else instance = this;
        }




    }
}

