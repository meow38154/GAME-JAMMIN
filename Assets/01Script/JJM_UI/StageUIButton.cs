using UnityEngine;

public class StageUIButton : MonoBehaviour
{
    public void Sound0()
    {
        DataManager.Instance.PlaySound(0);
        Debug.Log("»ç¿îµå 0");
    }

    public void Stage01()
    {
        GameManager.Instance.Scene(2);
        Sound0();
    }

    public void Stage02()
    {
        GameManager.Instance.Scene(3);
        Sound0();
    }

    public void Stage03()
    {
        GameManager.Instance.Scene(4);
        Sound0();
    }

    public void Stage04()
    {
        GameManager.Instance.Scene(5);
        Sound0();
    }

    public void Stage05()
    {
        GameManager.Instance.Scene(6);
        Sound0();
    }

    public void Stage06()
    {
        GameManager.Instance.Scene(7);
        Sound0();
    }

    public void Stage07()
    {
        GameManager.Instance.Scene(8);
        Sound0();
    }

    public void Stage08()
    {
        GameManager.Instance.Scene(9);
        Sound0();
    }

    public void Stage09()
    {
        GameManager.Instance.Scene(10);
        Sound0();
    }

    public void Stage10()
    {
        GameManager.Instance.Scene(11);
        Sound0();
    }
}
