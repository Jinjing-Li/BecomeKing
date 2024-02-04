using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrojanController : MonoBehaviour
{
    private float mMoveSpeed = 0.01f;
    private float mRotateSpeed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	float horizontal = Input.GetAxis("Horizontal");
        
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(0, vertical) * mMoveSpeed);

　　		transform.Rotate(new Vector3(0, 0, horizontal) * mRotateSpeed);
    
    }
}
