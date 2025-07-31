using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if (SoundManager.Instance.Volume != _slider.value)
        {
            _slider.value = SoundManager.Instance.Volume;
        }

        SoundManager.Instance.Volume = _slider.value;
    }
}
