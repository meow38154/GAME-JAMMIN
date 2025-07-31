using UnityEngine;
using UnityEngine.SceneManagement;

namespace SDW
{
    public class EXFinishManager : MonoBehaviour
    {
        [SerializeField] private int nextSceneIndex;

        public bool playerIn1;
        public bool playerIn2;
        public bool playerIn3;

        private void Update()
        {
            if (playerIn1 == true && playerIn2 == true && playerIn3 == true)
            {
                NextSceneLoad(nextSceneIndex);
            }
        }

        void NextSceneLoad(int nextSceneIndex)
        {
            GameManager.Instance.Scene(nextSceneIndex);
        }
    }
}
