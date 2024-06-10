using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteemScript : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Get");
        
    }
    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
