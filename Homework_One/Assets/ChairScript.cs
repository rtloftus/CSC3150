using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairScript : MonoBehaviour
{
    [SerializeField] float xMove = 0;
    [SerializeField] float yMove = 0;
    [SerializeField] float zMove = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am a component added to the prefab");
        transform.Translate(xMove,yMove, zMove);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I update with every frame of the prefab");
    }
}
