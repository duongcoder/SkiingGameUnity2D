using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float timeDelays = 2f;
    [SerializeField] ParticleSystem particleFinish;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            particleFinish.Play();
            GetComponent<AudioSource>().Play();
            Invoke("LoadScene", timeDelays);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
