using UnityEngine;
using UnityEngine.InputSystem;

public class UIOnOff : MonoBehaviour
{
    private bool _ui = false;  
    private Transform _transform;

    public bool UI => _ui;

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
        transform.parent.GetChild(1).GetComponent<OnEnableAnimation>().Play(false);
        transform.parent.GetChild(1).GetComponent<OnEnableAnimation>().Back(true);
        GetComponent<MainMenuButtonEvent>().Forward = false;
    }
}
