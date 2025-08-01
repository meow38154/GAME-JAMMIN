using UnityEngine;

namespace SDW
{
    public enum EXGravityDirection
    {
        None,
        Up,
        Down,
        Left,
        Right
    }

    public class EXGravity : MonoBehaviour
    {
        public EXGravityDirection gravityEnum = EXGravityDirection.None;
        private Vector3 gravityDirection;

        private void Start()
        {
            SetGravityDirection();
        }

        public void SetGravityDirection()
        {
            Debug.Log($"Setting gravity direction to: {gravityEnum}");
            switch (gravityEnum)
            {
                case EXGravityDirection.Up:
                    gravityDirection = Vector3.up;
                    break;
                case EXGravityDirection.Down:
                    gravityDirection = Vector3.down;
                    break;
                case EXGravityDirection.Left:
                    gravityDirection = Vector3.left;
                    break;
                case EXGravityDirection.Right:
                    gravityDirection = Vector3.right;
                    break;
                default:
                    gravityDirection = Vector3.zero;
                    break;
            }

            Physics2D.gravity = gravityDirection * Physics2D.gravity.magnitude;
        }
    }
}
