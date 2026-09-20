using System;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var animator = other.GetComponent<Animator>();
        
        animator.SetTrigger("Dance");
    }
}
