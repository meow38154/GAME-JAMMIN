using UnityEngine;
using UnityEngine.InputSystem;

public class UIOnOff : MonoBehaviour
{
    private bool _ui = false;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform.GetChild(0);
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            UIPlay();
        }
    }

    public void UIPlay()
    {
        _ui = !_ui;
        _transform.gameObject.SetActive(_ui);
    }
}
