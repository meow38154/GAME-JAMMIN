using UnityEngine;

namespace SDW
{
    public class EXGravityChange : MonoBehaviour
    {
        [SerializeField] private EXGravityDirection ChangeGravityEnum = EXGravityDirection.None;
        [SerializeField] private EXGravity gravity;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                gravity.gravityEnum = ChangeGravityEnum;
                gravity.SetGravityDirection();
                Destroy(gameObject);
            }
        }
    }
}