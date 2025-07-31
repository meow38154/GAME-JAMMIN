using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanImage : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprite;


    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        _image.sprite = _sprite[SettingManager.Instance.Language];
    }
}
