using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crack : MonoBehaviour
{
    [SerializeField] float timeDelays = 2f;
    [SerializeField] ParticleSystem particleCrash;
    [SerializeField] AudioClip crashSound;

    bool hasCrash = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hasCrash)
        {
            hasCrash = true;
            FindObjectOfType<Controller>().StopMove();
            particleCrash.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Invoke("LoadScene", timeDelays);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
