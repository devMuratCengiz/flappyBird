using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.itsOk)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (gameObject.transform.position.x <= -4f)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
