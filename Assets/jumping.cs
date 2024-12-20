using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        characterMotion(); //鍵盤控制
    }

    void characterMotion()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetTrigger("jumpTrigger");
        }
 
    }

}

