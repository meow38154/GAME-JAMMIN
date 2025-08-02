using UnityEngine;
using UnityEngine.SceneManagement;

public class StageUIButton : MonoBehaviour
{
    [SerializeField] private string[] _sceneName;

    public void Sound0()
    {
        DataManager.Instance.PlaySound(0);
        Debug.Log("»ç¿îµå 0");
    }
    public void Stage01()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[0]);
        Sound0();
    }

    public void Stage02()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[1]);
        Sound0();
    }

    public void Stage03()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[2]);
        Sound0();
    }

    public void Stage04()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[3]);
        Sound0();
    }

    public void Stage05()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[4]);
        Sound0();
    }

    public void Stage06()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[5]);
        Sound0();
    }

    public void Stage07()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[6]);
        Sound0();
    }

    public void Stage08()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[7]);
        Sound0();
    }

    public void Stage09()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[8]);
        Sound0();
    }

    public void Stage10()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName[9]);
        Sound0();
    }
}
