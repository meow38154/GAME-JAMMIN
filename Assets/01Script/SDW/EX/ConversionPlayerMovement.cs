using UnityEngine;
using UnityEngine.InputSystem;

namespace SDW
{
    public class ConversionPlayerMovement : MonoBehaviour
    {
        [SerializeField] private PlayerInput playerInput;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                if( playerInput != null)
                {
                    playerInput.enabled = !playerInput.enabled;
                }
                else
                {
                    Debug.LogWarning("PlayerInput 컴포넌트가 설정되지 않았습니다.");
                }
                Destroy(gameObject);
            }
        }
    }
}
