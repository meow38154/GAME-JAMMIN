using UnityEngine;
using System.Collections;

public class MusicSound : MonoBehaviour
{
    [SerializeField] private float _coolTime = 2;
    [SerializeField] private int _musicNumber;

    private void Start()
    {
        StartCoroutine(CoolTime());
    }

    private IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(_coolTime);
        MusicManager.Instance.PlayMusic(_musicNumber);
    }
}
