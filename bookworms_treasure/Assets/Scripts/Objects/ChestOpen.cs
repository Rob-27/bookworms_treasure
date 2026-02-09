using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.SetTrigger("PlayAnim");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
