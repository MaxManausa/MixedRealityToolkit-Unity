using System.Collections.Generic;
using UnityEngine;

public class ReverseParticlePlayback : MonoBehaviour
{
    public ParticleSystem originalParticleSystem;
    public ParticleSystem duplicateParticleSystem;

    private List<ParticleSystem.Particle> particles = new List<ParticleSystem.Particle>();

    private void Update()
    {
        if (originalParticleSystem != null && duplicateParticleSystem != null)
        {
            // Ensure the particles list is resized to fit the particle count
            int maxParticleCount = originalParticleSystem.main.maxParticles;
            if (particles.Count < maxParticleCount)
            {
                particles = new List<ParticleSystem.Particle>(maxParticleCount);
            }

            int particleCount = originalParticleSystem.GetParticles(particles.ToArray());

            // Resize the duplicate system's capacity to hold the same number of particles
            duplicateParticleSystem.Emit(particleCount);

            // Modify the particles in the duplicate system to match the reverse order
            ParticleSystem.Particle[] duplicateParticles = new ParticleSystem.Particle[particleCount];
            for (int i = 0; i < particleCount; i++)
            {
                duplicateParticles[i] = particles[particleCount - 1 - i];
            }

            duplicateParticleSystem.SetParticles(duplicateParticles, particleCount);
        }
    }
}