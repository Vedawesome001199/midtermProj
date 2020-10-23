using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class KayaController : MonoBehaviour
{
    public Transform displacement;
    static Animator anim;
    public float Speed = 10.0f; 
    public float rotationSpeed = 100.0f;
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

  
   public void AdjustSpeed(float newSpeed){
            Speed = newSpeed;
        }
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * Speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        float dist = Vector3.Distance(displacement.position, transform.position);
            Debug.Log(dist);

        if (Input.GetButtonDown("Jump")) 
        {
            anim.SetTrigger("isJumping");
        }
        if (translation != 0)
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isIdle", false);
        }
        else 
        {
            anim.SetBool("isRunning",false);
            anim.SetBool("isIdle", true);
        }
           

        }
    }

