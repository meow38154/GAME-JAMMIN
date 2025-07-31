using UnityEngine;

namespace Irw_Button
{
    public class Door : MonoBehaviour, ButtonDawnIntercace
    {
        public void ButtonDawnComplete()
        {
            gameObject.SetActive(false);
        }

        public void ButtonDawnNotComplete()
        {
            gameObject.SetActive(true);
        }
    }
}

