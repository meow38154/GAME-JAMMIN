using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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

    public void MainPlay()
    {
        for (int i = 0; i < 3; i++)
        {
            transform.GetChild(i).GetComponent<OnEnableAnimation>().Play(false);
            transform.GetChild(i).GetComponent<OnEnableAnimation>().Back(true);
        }

        transform.parent.GetChild(1).GetComponent<OnEnableAnimation>().Play(false);
        transform.parent.GetChild(1).GetComponent<OnEnableAnimation>().Back(true);

        transform.parent.GetChild(2).GetComponent<OnEnableAnimation>().Play(false);
        transform.parent.GetChild(2).GetComponent<OnEnableAnimation>().Back(true);
        StartCoroutine(CoolTime());
    }

    private IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);
    }
}
