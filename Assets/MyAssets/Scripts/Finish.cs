using System;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    
    private void OnTriggerEnter(Collider other)
    {
        var animator = other.GetComponentInChildren<Animator>();
        
        audioSource.Play();
        animator.SetTrigger("Dance");
        
        var playrMove = FindFirstObjectByType<PlayerMove>();
        
        playrMove.StopMove();
    }
}
