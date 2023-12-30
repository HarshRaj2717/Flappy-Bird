using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    public int MoveSpeed = 25;
    public int LeftMovementLimit = -60;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
        if (transform.position.x < LeftMovementLimit)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
