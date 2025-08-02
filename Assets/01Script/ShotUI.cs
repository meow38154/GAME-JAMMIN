using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ShotUI : MonoBehaviour
{
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                ShotPlay();
            }
        }
    }

    public void ShotPlay()
    {
        GetComponent<OnEnableAnimation>().Play(false);
    }

    public void Buy1()
    {
        if (DataManager.Instance.HiddenStage[0])
        {
            DataManager.Instance.PlaySound(0);
            GameManager.Instance.Scene(12);
        }

        if (10 <= DataManager.Instance.Coin && !DataManager.Instance.HiddenStage[0])
        {

            DataManager.Instance.HiddenStage[0] = true;
            DataManager.Instance.Coin -= 10;
            DataManager.Instance.PlaySound(8);
        }
    }

    public void Buy2()
    {
        if (DataManager.Instance.HiddenStage[1])
        {
            DataManager.Instance.PlaySound(0);
            GameManager.Instance.Scene(13);
        }

        if (20 <= DataManager.Instance.Coin && !DataManager.Instance.HiddenStage[1])
        {
            
            DataManager.Instance.HiddenStage[1] = true;
            DataManager.Instance.Coin -= 20;
            DataManager.Instance.PlaySound(8);
        }
    }

    public void Buy3()
    {
        if (DataManager.Instance.HiddenStage[2])
        {
            DataManager.Instance.PlaySound(0);
            GameManager.Instance.Scene(14);
        }

        if (25 <= DataManager.Instance.Coin && !DataManager.Instance.HiddenStage[2])
        {

            DataManager.Instance.HiddenStage[2] = true;
            DataManager.Instance.Coin -= 25;
            DataManager.Instance.PlaySound(8);
        }
    }
}

