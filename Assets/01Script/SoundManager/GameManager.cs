using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [field: SerializeField] public GameObject UI { get; private set; }
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

    public void Scene(int num)
    {
        SceneManager.LoadScene(num);
    }
}
