using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroyObject : MonoBehaviour
{

    [SerializeField] private GameObject object1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", 3f);
    }

    public void DestroyObject()
    {
        Destroy(object1);
        Debug.Log(object1 + " was just destroyed");
    }
}
