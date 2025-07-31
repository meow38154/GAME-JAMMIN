using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [field: SerializeField] public GameObject UI { get; private set; }

    public event Action Reset;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void ResetButton()
    {
        Reset?.Invoke();
    }

    public void Scene(int num)
    {
        StartCoroutine(SceneChange(num));
    }

    private IEnumerator SceneChange(int num)
    {
        Time.timeScale = 0;
        UI.transform.parent.transform.GetChild(2).GetComponent<FadeSystem>().FadeIn(0.4f, true);
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(num);
    }
}
