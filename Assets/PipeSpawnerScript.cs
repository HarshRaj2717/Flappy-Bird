using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, PipeSpawingPos(), transform.rotation);
            timer = 0;
        }
    }

    Vector3 PipeSpawingPos()
    {
        float lowsetPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        return new Vector3(transform.position.x, Random.Range(lowsetPoint, highestPoint), 0);
    }

}
