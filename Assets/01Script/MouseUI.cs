using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MouseUI : MonoBehaviour
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
}

