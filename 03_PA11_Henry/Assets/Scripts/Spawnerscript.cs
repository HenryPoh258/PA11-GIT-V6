using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject;
    public GameObject SpawnObject2;
    public GameObject SpawnObject3;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFirstObjects", 1, 3);
        InvokeRepeating("SpawnSecondObjects", 2, 3);
        InvokeRepeating("SpawnThirdObjects", 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnFirstObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject, transform.position, transform.rotation);
    }

    void SpawnSecondObjects ()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject2, transform.position, transform.rotation);

    }

    void SpawnThirdObjects ()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject3, transform.position, transform.rotation);
    }
}
