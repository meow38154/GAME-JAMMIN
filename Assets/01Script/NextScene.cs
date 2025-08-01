using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] private float _time = 5;

    [SerializeField] private GameObject _logo;

    [SerializeField] private AudioSource source;

    private void Start()
    {
        StartCoroutine(Cool());
    }

    private IEnumerator Cool()
    {
        yield return new WaitForSeconds(2);
        source.Play();
        StartCoroutine(NextSceneCoolTime());
        StartCoroutine(LogoTime());
    }

    private IEnumerator NextSceneCoolTime()
    {
        yield return new WaitForSeconds(_time);
        SceneManager.LoadScene(16);
    }

    private IEnumerator LogoTime()
    {
        _logo.SetActive(true);
        yield return new WaitForSeconds(3f);
        _logo.SetActive(false);
    }
}
