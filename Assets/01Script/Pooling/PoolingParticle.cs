using UnityEngine;

public class PoolingParticle : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField] private int _count;
    public int Count { get; set; }

    GameObject[] _objects;

    void Awake()
    {
        _objects = new GameObject[_count];
        for (int i = 0; i < _count; i++)
        {
            GameObject eggAttack = Instantiate(_object, transform);
            eggAttack.GetComponent<ParticleSystem>().Stop();
            _objects[i] = eggAttack;
        }
    }

    private void Update()
    {
        _count = Count;
    }
}
