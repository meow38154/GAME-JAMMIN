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

        private void Awake()
        {
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
            }
        }

        private void Start()
        {
            SetGravityDirection();
        }

        public void SetGravityDirection()
        {
            if (gravityEnum != EXGravityDirection.None)
            {            
                Physics2D.gravity = gravityDirection * Physics2D.gravity.magnitude;
            }
            else
            {
                Physics2D.gravity = Vector2.zero;
            }
        }
    }
}
