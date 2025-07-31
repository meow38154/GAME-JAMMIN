using TMPro;
using UnityEngine;

public class LanText : MonoBehaviour
{
    [SerializeField] private string[] _text;


    private TextMeshProUGUI _textGUI;

    private void Awake()
    {
        _textGUI = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (_textGUI.text != _text[SettingManager.Instance.Language])
        {
            _textGUI.font = SettingManager.Instance.Font[SettingManager.Instance.Language];
        }


        _textGUI.text = _text[SettingManager.Instance.Language];
    }
}
