using UnityEngine;

namespace SDW
{
    public class EXGravityChange : MonoBehaviour
    {
        [SerializeField] private EXGravityDirection ChangeGravityEnum = EXGravityDirection.None;
        private EXGravity gravity;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                gravity.gravityEnum = ChangeGravityEnum;
                gravity.SetGravityDirection();
                Destroy(gameObject);
            }
        }
    }
}