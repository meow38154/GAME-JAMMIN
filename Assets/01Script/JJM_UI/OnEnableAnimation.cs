using System.Collections;
using UnityEngine;

public class OnEnableAnimation : MonoBehaviour
{
    [SerializeField] private float _coolTime = 0;
    [SerializeField] private Vector2 _targetPosition;
    [SerializeField] private Vector2 _resetPosition;
    [SerializeField] private float _speed = 10;

    private RectTransform _rectTransform;

    private bool _play;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        _play = false;
        _rectTransform.anchoredPosition = _resetPosition;
        StartCoroutine(CoolTime(_coolTime));
    }

    private void Update()
    {
        if (_play)
        {
            _rectTransform.anchoredPosition = Vector2.Lerp(_rectTransform.anchoredPosition, _targetPosition, _speed * Time.deltaTime);
        }
    }

    private IEnumerator CoolTime(float time)
    {
        yield return new WaitForSeconds(time);
        _play = true;
    }
}
