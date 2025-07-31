using System;
using UnityEngine;

public class MenuButtonEvent : MonoBehaviour
{
    #region Event
    public event Action ContinueEvent;
    public event Action OptionEvent;
    public event Action ExitEvent;
    #endregion

    private UIOnOff _onOff;


    private void Awake()
    {

        _onOff = GetComponent<UIOnOff>();
        ContinueEvent += _onOff.UIPlay;
    }

    public void ResetButton()
    {
        GameManager.Instance.ResetButton();
        Continue();
    }    

    public void Continue()
    {
        Time.timeScale = 1;
        ContinueEvent?.Invoke();
    }
    public void Option()
    {
        OptionEvent?.Invoke();
    }
    public void Exit()
    {
        ExitEvent?.Invoke();
        GameManager.Instance.Scene(1);
    }
}
