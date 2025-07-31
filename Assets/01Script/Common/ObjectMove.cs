using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private MoveType _moveType;
    public MoveType MovementType => _moveType;



    [SerializeField] private Vector3 _moveVector;
    public Vector3 MoveVector => _moveVector;

    [SerializeField] private bool _translate;
    public bool Translate => _translate;



    [SerializeField] private Transform _target;
    public Transform Target => _target;

    [SerializeField] private bool _lerp = true;
    public bool Lerp => _lerp;

    [SerializeField] private float _speed = 5;
    public float Speed => _speed;

    void Update()
    {
        //타겟이 있을 때 유도되는 코드
        if (Target != null)
        {
            if (_lerp)
            {
                Vector2 moveDir = _target.position - transform.position;
                transform.position += (Vector3)moveDir * _speed * Time.deltaTime;
            }

            if (!_lerp)
            {
                Vector2 moveDir = _target.position - transform.position;
                transform.position += (Vector3)moveDir.normalized * _speed * Time.deltaTime;
            }
        }
        else
        {
            if (_translate)
            {
                transform.Translate(_moveVector * Time.deltaTime * _speed);
            }

            if (_moveVector != Vector3.zero)
            {
                transform.position += _moveVector * Time.deltaTime * _speed;
            }
        }
    }

    private void OnValidate()
    {
#if UNITY_EDITOR
        if (_moveType != MoveType.Basic)
        {
            _moveVector = Vector3.zero;
            _translate = false;
        }

        if (_moveType != MoveType.Follow)
        {
            _target = null;
            _lerp = false;
            _speed = 0;
        }
#endif
    }
}

public enum MoveType
{
    None, Basic, Follow
}
