using TMPro;
using UnityEngine;

public class NumText : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _text.text = DataManager.Instance.Coin.ToString();
    }
}
