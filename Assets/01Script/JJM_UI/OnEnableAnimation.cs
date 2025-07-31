using System.Collections;
using UnityEngine;

public class OnEnableAnimation : MonoBehaviour
{
    [SerializeField] private int _max;

    [SerializeField] private float _coolTime = 0;
    [SerializeField] private Vector2 _targetPosition;
    [SerializeField] private Vector2 _resetPosition;
    [SerializeField] private float _speed = 10;

    private RectTransform _rectTransform;

    private bool _play, _back;

    [SerializeField] private bool _startOnEnable = true;

    private void Start()
    {
        TryStartAnimation();
    }

    private void OnEnable()
    {
        TryStartAnimation();
    }

    private void TryStartAnimation()
    {
        Time.timeScale = 1;
        Debug.Log("애니메이션 호출됨");

        _rectTransform = GetComponent<RectTransform>();
        if (_startOnEnable)
        {

            _back = false;
            _play = false;
            _rectTransform.anchoredPosition = _resetPosition;
            StartCoroutine(CoolTime(_coolTime));
        }
    }


    private void Update()
    {

        if (_play)
        {
            _rectTransform.anchoredPosition = Vector2.Lerp(_rectTransform.anchoredPosition, _targetPosition, _speed * Time.deltaTime);
        }

        if (_back)
        {
            _rectTransform.anchoredPosition = Vector2.Lerp(_rectTransform.anchoredPosition, _resetPosition, _speed * Time.deltaTime);
        }
    }

    public void Play(bool value)
    {
        _play = value;
        _back = !value;
    }
    public void Back(bool value)
    {
        _back = value;
        _play = !value;
    }


    private IEnumerator CoolTime(float time)
    {
        yield return new WaitForSeconds(time);
        _play = true;
    }

    public void Up()
    {
        SettingManager.Instance.PlaySound(0);
        if (SettingManager.Instance.Language >= _max - 1)
        {
            SettingManager.Instance.Language = 0;
        }
        else
        {
            SettingManager.Instance.Language += 1;
        }
    }

    public void Down()
    {
        SettingManager.Instance.PlaySound(0);
        if (SettingManager.Instance.Language <= 0)
        {
            SettingManager.Instance.Language = _max - 1;
        }
        else
        {
            SettingManager.Instance.Language -= 1;
        }
    }

}
