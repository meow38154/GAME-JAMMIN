using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 _savePos;

    [SerializeField] private float _speed = 5;

    private Rigidbody2D _rb;
    private Vector2 _moveDir;

    private void Awake()
    {
        _savePos = transform.position;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    //ÇÊ¿ä ½Ã
    public void OnJump(InputValue value)
    {

    }

    private void FixedUpdate()
    {
        if (!GameManager.Instance.UI.GetComponent<UIOnOff>().UI)
        _rb.linearVelocity = _moveDir * _speed;
    }
    public void OnMove(InputValue value)
    {
        _moveDir = value.Get<Vector2>();
    }

}
