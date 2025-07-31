using UnityEngine;
using UnityEngine.SceneManagement;

public class StageUI : MonoBehaviour
{
    [SerializeField] private string[] _sceneName;

    public void Stage01()
    {
        SceneManager.LoadScene(_sceneName[0]);
    }

    public void Stage02()
    {
        SceneManager.LoadScene(_sceneName[1]);
    }

    public void Stage03()
    {
        SceneManager.LoadScene(_sceneName[2]);
    }

    public void Stage04()
    {
        SceneManager.LoadScene(_sceneName[3]);
    }

    public void Stage05()
    {
        SceneManager.LoadScene(_sceneName[4]);
    }

    public void Stage06()
    {
        SceneManager.LoadScene(_sceneName[5]);
    }

    public void Stage07()
    {
        SceneManager.LoadScene(_sceneName[6]);
    }

    public void Stage08()
    {
        SceneManager.LoadScene(_sceneName[7]);
    }

    public void Stage09()
    {
        SceneManager.LoadScene(_sceneName[8]);
    }

    public void Stage10()
    {
        SceneManager.LoadScene(_sceneName[9]);
    }
}
