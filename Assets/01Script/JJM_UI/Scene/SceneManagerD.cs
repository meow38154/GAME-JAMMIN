using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;
using UnityEngine.InputSystem;

public class SceneManagerD : MonoBehaviour
{
    public static SceneManagerD Instance;

    [SerializeField] private float _speed = 4;
    private Image[] _images;

    [SerializeField] private Color _startColor;
    [SerializeField] private Color _endColor;

    private RectTransform[] _rectTransform;

    private void Awake()
    {
        _images = new Image[transform.childCount];
        _rectTransform = new RectTransform[transform.childCount];

        for (int i = 0; i < 5; i++)
        {
            _images[i] = transform.GetChild(i).GetComponent<Image>();
            _rectTransform[i] = transform.GetChild(i).GetComponent<RectTransform>();
        }

        DontDestroyOnLoad(gameObject);



        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }


    private void Update()
    {
        if (Keyboard.current.oKey.wasPressedThisFrame)
        {
            SceneStart();
        }

        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            SceneEnd();
        }
    }

    public void SceneStart()
    {
        StartCoroutine(SceneStartC());
    }

    public void SceneEnd()
    {
        StartCoroutine(SceneEndC());
    }

    public IEnumerator SceneStartC()
    {
        SquareMove(3840f, _startColor, 3);
        yield return new WaitForSeconds(0.04f);
        SquareMove(3840f, _startColor, 0);
        yield return new WaitForSeconds(0.04f);
        SquareMove(3840f, _startColor, 1);
        yield return new WaitForSeconds(0.04f);
        SquareMove(3840f, _startColor, 2);
        yield return new WaitForSeconds(0.04f);
        SquareMove(3840f, _startColor, 4);
        yield return new WaitForSeconds(0.04f);
    }

    public IEnumerator SceneEndC()
    {
        SquareMove(0f, _endColor, 4);
        yield return new WaitForSeconds(0.04f);
        SquareMove(0f, _endColor, 2);
        yield return new WaitForSeconds(0.04f);
        SquareMove(0f, _endColor, 1);
        yield return new WaitForSeconds(0.04f);
        SquareMove(0f, _endColor, 0);
        yield return new WaitForSeconds(0.04f);
        SquareMove(0f, _endColor, 3);
        yield return new WaitForSeconds(0.04f);
    }

    private void SquareMove(float size, Color targetColor, int num)
    {
        RectTransform rt = _rectTransform[num];
        Image img = _images[num];

        rt.DOSizeDelta(new Vector2(size, rt.sizeDelta.y), 1f / _speed).SetEase(Ease.InOutSine);

        img.DOColor(targetColor, 1f / _speed).SetEase(Ease.InOutSine);
    }
}
