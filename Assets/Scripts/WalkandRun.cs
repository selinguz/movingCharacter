using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkandRun : MonoBehaviour
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

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0,0,2f)*Time.deltaTime);

     
        } else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("isRunning", true);
            transform.Translate(new Vector3(2f, 0, 4f)*Time.deltaTime);
        
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(-2f, 0, 4f) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(2f, 0, 4f) * Time.deltaTime);
          

        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 46f, 57f), transform.position.y, transform.position.z);
    }

    
}
