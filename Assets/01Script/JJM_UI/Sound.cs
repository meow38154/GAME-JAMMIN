using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _slider.value = SettingManager.Instance.Volume;
    }

    private void Update()
    {
        SettingManager.Instance.Volume = _slider.value;
    }
}
