using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewParticleSystem : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemToSpawn;
    
    public void SpawnParticleSystem()
    {
        Instantiate(_particleSystemToSpawn, transform.position, Quaternion.identity);
    }
}
