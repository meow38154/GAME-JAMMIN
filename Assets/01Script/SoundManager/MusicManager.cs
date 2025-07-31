using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance; 

    [field: SerializeField] public AudioClip[] Music { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (TryGetComponent(out AudioSource audio))
        {
            audio.volume = SettingManager.Instance.Volume;
        }
    }

    public void PlayMusic(int num)
    {
        if (TryGetComponent(out AudioSource audio))
        {
            if (audio.clip == Music[num] && audio.isPlaying)
                return;

            Destroy(audio);
        }

        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.clip = Music[num];
        source.loop = true;
        source.Play();
    }

}
