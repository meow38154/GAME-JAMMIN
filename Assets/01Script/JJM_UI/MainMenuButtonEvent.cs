using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuButtonEvent : MonoBehaviour
{
    private GameObject _gameObject;

    private OnEnableAnimation _on;

    public bool Forward { get; set; }

    private void Awake()
    {
        _gameObject = transform.parent.transform.GetChild(1).gameObject;
        _on = _gameObject.GetComponent<OnEnableAnimation>();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MainOption()
    {
        DataManager.Instance.PlaySound(0);
        Forward = !Forward;

        _on.Play(Forward);
        _on.Back(!Forward);
    }

    public void MainPlay()
    {
        DataManager.Instance.PlaySound(0);
        ButtonMove();
        StartCoroutine(CoolTime());
    }

    private void ButtonMove()
    {
        for (int i = 0; i < 4; i++)
        {
            transform.GetChild(i).GetComponent<OnEnableAnimation>().Play(false);
            transform.GetChild(i).GetComponent<OnEnableAnimation>().Back(true);
        }

        transform.parent.GetChild(1).GetComponent<OnEnableAnimation>().Play(false);
        transform.parent.GetChild(1).GetComponent<OnEnableAnimation>().Back(true);

        transform.parent.GetChild(2).GetComponent<OnEnableAnimation>().Play(false);
        transform.parent.GetChild(2).GetComponent<OnEnableAnimation>().Back(true);
    }

    private IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    private IEnumerator CoolTimeT()
    {
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(15);
    }

    public void Tutorial()
    {
        DataManager.Instance.PlaySound(0);
        ButtonMove();
        StartCoroutine(CoolTimeT());
    }
}
