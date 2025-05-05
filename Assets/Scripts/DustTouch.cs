using UnityEngine;

public class DustTouch : MonoBehaviour
{
    [SerializeField] ParticleSystem dust;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dust.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dust.Stop();
        }
    }
}
