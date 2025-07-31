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
        _slider.value = SoundManager.Instance.Volume;
    }

    private void Update()
    {
        SoundManager.Instance.Volume = _slider.value;
    }
}
