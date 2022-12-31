using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public Rigidbody rigidBody;
    public GameObject UnderwaterBox;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        rigidBody.useGravity = false;
        UnderwaterBox.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        rigidBody.useGravity = true;
        UnderwaterBox.SetActive(false);
    }

}
