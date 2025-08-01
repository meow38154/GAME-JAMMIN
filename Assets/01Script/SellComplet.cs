using UnityEngine;

public class SellComplet : MonoBehaviour
{
    [SerializeField] private int num;

    private void Update()
    {
        if (DataManager.Instance.HiddenStage[num])
        {
            transform.GetChild(0).gameObject.SetActive(!DataManager.Instance.HiddenStage[num]);
            transform.GetChild(1).gameObject.SetActive(DataManager.Instance.HiddenStage[num]);
        }
    }
}
