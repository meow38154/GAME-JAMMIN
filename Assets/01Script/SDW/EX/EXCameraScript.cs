using UnityEngine;

namespace SDW
{
    public class EXCameraScript : MonoBehaviour
    {
        [SerializeField] private float _minCameraSize = 4f;
        [SerializeField] private float _maxCameraSize = 10f;
        [SerializeField] private float _speed = 5;
        [SerializeField] private float _basu = 1.2f;

        [SerializeField] private Transform _player1;
        [SerializeField] private Transform _player2;
        [SerializeField] private Transform _player3;

        private Camera _camera;

        private void Awake()
        {
            _camera = GetComponent<Camera>();
        }

        private void FixedUpdate()
        {
            // 평균 위치로 이동
            Vector3 averagePos = (_player1.position + _player2.position + _player3.position) / 3f;
            Vector3 targetPos = new Vector3(averagePos.x, averagePos.y, -10f);
            transform.position = Vector3.Lerp(transform.position, targetPos, _speed * Time.fixedDeltaTime);

            // 플레이어들을 모두 포함하는 bounding box 계산
            float minX = Mathf.Min(_player1.position.x, _player2.position.x, _player3.position.x);
            float maxX = Mathf.Max(_player1.position.x, _player2.position.x, _player3.position.x);
            float minY = Mathf.Min(_player1.position.y, _player2.position.y, _player3.position.y);
            float maxY = Mathf.Max(_player1.position.y, _player2.position.y, _player3.position.y);

            float width = maxX - minX;
            float height = maxY - minY;

            // 화면 비율 고려
            float targetSize = Mathf.Max(height, width / _camera.aspect) * _basu;

            // 사이즈 보간 및 제한
            _camera.orthographicSize = Mathf.Clamp(
                Mathf.Lerp(_camera.orthographicSize, targetSize, _speed * Time.fixedDeltaTime),
                _minCameraSize,
                _maxCameraSize
            );
        }
    }
}
