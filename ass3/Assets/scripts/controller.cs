using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private CharacterController _character;
    private Animator _animator;
    private Vector3 _MoveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        _character = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);
        
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);

            _animator.SetBool("isRun", true);

            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("isRun",false);
        }
       
    }

    
}
