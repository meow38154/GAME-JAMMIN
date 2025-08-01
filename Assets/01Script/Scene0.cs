using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;

public class Scene0 : MonoBehaviour
{
    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            StartCoroutine(SceneChange());
        }
    }

    private IEnumerator SceneChange()
    {
        DataManager.Instance.PlaySound(1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<OnEnableAnimation>().Back(true);
        }

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(16);
    }

    public void ShotPlay()
    {
        DataManager.Instance.PlaySound(0);

        transform.GetChild(3).GetComponent<OnEnableAnimation>().Play(true);
    }
}
