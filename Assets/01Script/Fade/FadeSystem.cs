using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeSystem : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Image _image;

    private Tween _spriteTween;
    private Tween _imageTween;

    private void Awake()
    {
        if (TryGetComponent<SpriteRenderer>(out SpriteRenderer sprite))
        {
            _spriteRenderer = sprite;
        }

        if (TryGetComponent<Image>(out Image image))
        {
            _image = image;
        }
    }

    private void Start()
    {
        FadeOut(2f, true);
    }

    public void FadeIn(float duration = 1f, bool ignoreTimeScale = false)
    {
        if (_spriteRenderer != null)
        {
            _spriteTween?.Kill();
            _spriteTween = _spriteRenderer.DOFade(1f, duration).SetUpdate(ignoreTimeScale);
        }

        if (_image != null && _image.gameObject != null)
        {
            _imageTween?.Kill();
            _imageTween = _image.DOFade(1f, duration).SetUpdate(ignoreTimeScale);
        }
    }

    public void FadeOut(float duration = 1f, bool ignoreTimeScale = false)
    {
        if (_spriteRenderer != null)
        {
            _spriteTween?.Kill();
            _spriteTween = _spriteRenderer.DOFade(0f, duration).SetUpdate(ignoreTimeScale);
        }

        if (_image != null && _image.gameObject != null)
        {
            _imageTween?.Kill();
            _imageTween = _image.DOFade(0f, duration).SetUpdate(ignoreTimeScale);
        }
    }

    private void OnDestroy()
    {
        _spriteTween?.Kill();
        _imageTween?.Kill();
    }
}
