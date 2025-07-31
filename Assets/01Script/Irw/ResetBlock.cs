using Irw_Button;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float ResetTime = 3;
    private float currentTime = 0;
    [SerializeField] private LayerMask playerLayer;

    private void Update()
    {
        Collider2D a = Physics2D.OverlapBox(transform.position, transform.lossyScale, 0, playerLayer);
        if (a != null)
        {
            currentTime += Time.deltaTime;
            if (currentTime >= ResetTime) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            currentTime = 0;
        }
    }


}
