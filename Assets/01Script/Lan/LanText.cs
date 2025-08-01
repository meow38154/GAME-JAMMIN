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
        if (_textGUI.text != _text[DataManager.Instance.Language])
        {
            _textGUI.font = DataManager.Instance.Font[DataManager.Instance.Language];
        }


        _textGUI.text = _text[DataManager.Instance.Language];
    }
}
