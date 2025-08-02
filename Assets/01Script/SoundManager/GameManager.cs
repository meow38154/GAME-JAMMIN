using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [field: SerializeField] public GameObject UI { get; private set; }

    public bool Move { get; private set; }

    public event Action Reset;

    private bool _yes;
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
        if (!_yes)
        {
            SceneManagerD.Instance.SceneStart();
            _yes = true;
        }
        Debug.Log("Ω√¿€");
        Move = true;
        yield return new WaitForSeconds(0.5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(num);
        SceneManagerD.Instance.SceneEnd();
        Debug.Log("≥°");
    }
}
