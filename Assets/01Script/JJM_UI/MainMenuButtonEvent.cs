using UnityEngine;

public class MainMenuButtonEvent : MonoBehaviour
{
    private GameObject _gameObject;

    private OnEnableAnimation _on;

    private bool _forward;

    private void Awake()
    {
        _gameObject = transform.parent.transform.GetChild(1).gameObject;
        _on = _gameObject.GetComponent<OnEnableAnimation>();
    }

    public void MainOption()
    {
        _forward = !_forward;

        _on.Play(_forward);
        _on.Back(!_forward);
    }
}
