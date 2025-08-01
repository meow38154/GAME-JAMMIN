using TMPro;
using UnityEngine;

public class LanText3D : MonoBehaviour
{
    [SerializeField] private string[] _text;


    private TextMeshPro _textGUI;

    private void Awake()
    {
        _textGUI = GetComponent<TextMeshPro>();
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
