using UnityEngine;

public class ParticlesOnApproach : MonoBehaviour
{
    public ParticleSystem particles;

    void OnTriggerEnter(Collider other)
    {
        particles.Play();
    }

    void OnTriggerExit(Collider other)
    {
        particles.Stop();
    }
}
