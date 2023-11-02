using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipesPrefab;
    private float yRange = .6f;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnPipe()
    {
        if (PlayerController.itsOk)
        {
            float randomY = Random.Range(-yRange, 1f);
            Vector3 tempVec = transform.position;
            tempVec.y = randomY;
            Instantiate(pipesPrefab, tempVec, Quaternion.identity);
        }
        
    }
}
