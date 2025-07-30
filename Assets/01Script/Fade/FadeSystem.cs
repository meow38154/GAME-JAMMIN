using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeSystem : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Image _image;

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

    public void FadeIn(float duration = 1f)
    {
        if (_spriteRenderer != null)
        {
            _spriteRenderer.DOFade(1f, duration);
        }

        if (_image != null)
        {
            _image.DOFade(1f, duration);
        }
    }

    public void FadeOut(float duration = 1f)
    {
        if (_spriteRenderer != null)
        {
            _spriteRenderer.DOFade(0f, duration);
        }

        if (_image != null)
        {
            _image.DOFade(0f, duration);
        }
    }
}
