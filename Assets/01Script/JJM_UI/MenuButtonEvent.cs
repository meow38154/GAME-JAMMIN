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
        SettingManager.Instance.PlaySound(2);
        GameManager.Instance.ResetButton();
        Continue();
    }    

    public void Continue()
    {
        SettingManager.Instance.PlaySound(0);
        Time.timeScale = 1;
        ContinueEvent?.Invoke();
    }
    public void Option()
    {
        SettingManager.Instance.PlaySound(0);
        OptionEvent?.Invoke();
    }
    public void Exit()
    {
        SettingManager.Instance.PlaySound(0);
        ExitEvent?.Invoke();
        GameManager.Instance.Scene(1);
    }
}
