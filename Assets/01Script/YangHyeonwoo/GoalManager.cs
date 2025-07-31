using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalManager : MonoBehaviour
{
    [SerializeField] private int nextSceneIndex;

    public bool playerIn1;
    public bool playerIn2;

    private void Update()
    {
        if (playerIn1 == true && playerIn2 == true)
        {
            NextSceneLoad(nextSceneIndex);
        }
    }

    void NextSceneLoad(int nextSceneIndex)
    {
        SceneManager.LoadScene(nextSceneIndex);
    }
}
