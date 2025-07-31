using UnityEngine;
using UnityEngine.InputSystem;

public class UIOnOff : MonoBehaviour
{
    public bool UI { get; set;}
    private Transform _transform;

    private void Awake()
    {
        _transform = transform.GetChild(0);
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            UI = !UI;
            _transform.gameObject.SetActive(UI);
        }
    }
}
