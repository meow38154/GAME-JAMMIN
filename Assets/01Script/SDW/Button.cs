using UnityEngine;

namespace SDW
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private GameObject _door;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                _door.SetActive(!_door.activeSelf);
            }
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                _door.SetActive(!_door.activeSelf);
            }
        }
    }
}
