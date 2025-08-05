using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 _savePos;

    [SerializeField] private Gradient _color;
    [SerializeField] private Gradient _color2;

    [SerializeField] private float _speed = 5;

    private Rigidbody2D _rb;
    private Vector2 _moveDir;

    private Animator _anim;
    private TrailRenderer _trail;

    private void Awake()
    {
        _savePos = transform.position;
        _rb = GetComponent<Rigidbody2D>();

        _anim = GetComponent<Animator>();
        _trail = transform.GetChild(0).GetComponent<TrailRenderer>();
    }

    private void Start()
    {
        GameManager.Instance.Reset += ResetPlay;

    }

    private void Update()
    {
        if (_anim.runtimeAnimatorController.name == "Player_B")
        {
            _trail.colorGradient = _color;
        }

        if (_anim.runtimeAnimatorController.name == "Player-EX")
        {
            _trail.colorGradient = _color2;
        }
    }

    //필요 시
    public void OnJump(InputValue value)
    {

    }

    public void ResetPlay()
    {
        Debug.Log("리셋됨!");
        transform.position = (Vector3)_savePos;
    }

    private void FixedUpdate()
    {
        if (!GameManager.Instance.UI.GetComponent<UIOnOff>().UI || !GameManager.Instance.Move)

        _rb.linearVelocity = _moveDir * _speed;
    }
    public void OnMove(InputValue value)
    {
        _moveDir = value.Get<Vector2>();
    }

}
