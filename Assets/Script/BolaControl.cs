using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaControl : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    public AudioClip _somHit, _somAttack;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ground")
        {
            Debug.Log("Tocou no chao");
            _audioSource.Play();
        }
    }
}
