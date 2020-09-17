using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public Animator animator;
    bool scared = false;
    bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //This is WIP only used to test movement animations
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;

        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position + vertical * Time.deltaTime;
        //if (transform.position + vertical * Time.deltaTime == new Vector3(0f, 0f, 0f))
        //{
        //    animator.SetBool("moving", false);
        //}
        //else
        //{
        //    animator.SetBool("moving", true);
        //}
            

        //This is a test in progress to test the scared state (PRESS SPACE TO ENTER SCARED STATE)
        if (Input.GetKeyDown(KeyCode.Space) && scared == true)
        {
            Debug.Log("Space pressed scared = false");
            scared = false;
            animator.SetBool("Scared", false);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && scared == false)
        {
            Debug.Log("Space pressed scared = true");
            scared = true;
            animator.SetBool("Scared", true);
        }

        //This is a test to enter the dead state (TO ENTER DEAD STATE PRESS E HOWEVER IT CAN ONLY BE ACTIVATED IF SCARED STATE HAS BEEN ENTERED e.g. SPACE then E)
        if (Input.GetKeyDown(KeyCode.E) && dead == true)
        {
            Debug.Log("E pressed dead = false");
            dead = false;
            animator.SetBool("Dead", false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && dead == false)
        {
            Debug.Log("Space pressed dead = true");
            dead = true;
            animator.SetBool("Dead", true);
        }
    }
}
