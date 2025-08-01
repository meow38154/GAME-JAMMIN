using UnityEngine;

public class PoolSpawn : MonoBehaviour
{
    public GameObject PoolSpawnPlay()
    {
        if (TryGetComponent<PoolingParticle>(out PoolingParticle _particle))
        {
            for (int i = 0; i < _particle.Count; i++)
            {
                var ps = transform.GetChild(i).gameObject.GetComponent<ParticleSystem>();
                if (!ps.isPlaying)
                {

                    ps.Play();
                    return ps.gameObject;
                }
            }
        }

        return null;
    }
}
