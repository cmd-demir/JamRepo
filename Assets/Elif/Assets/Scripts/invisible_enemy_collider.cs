using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible_enemy_collider : MonoBehaviour
{   
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>(); 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("isFollowing", true);
        }
    }
}
