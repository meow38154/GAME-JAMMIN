using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _basu = 0.5f;

    [SerializeField] private Transform _player1;
    [SerializeField] private Transform _player2;

    private Camera _camera;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3((_player2.position.x + _player1.position.x) / 2, (_player2.position.y + _player1.position.y) / 2, -10), _speed * Time.fixedDeltaTime);

        _camera.orthographicSize = Mathf.Lerp(_camera.orthographicSize, Vector2.Distance(_player1.position, _player2.position * _basu), _speed * Time.fixedDeltaTime);
    }
}
