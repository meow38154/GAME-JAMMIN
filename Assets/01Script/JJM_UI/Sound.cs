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
        _slider.value = DataManager.Instance.Volume;
    }

    private void Update()
    {
        DataManager.Instance.Volume = _slider.value;
    }
}
