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

    public void MainOption()
    {
        SoundManager.Instance.PlaySound(0);
        Forward = !Forward;

        _on.Play(Forward);
        _on.Back(!Forward);
    }

    public void MainPlay()
    {
        SoundManager.Instance.PlaySound(0);
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
