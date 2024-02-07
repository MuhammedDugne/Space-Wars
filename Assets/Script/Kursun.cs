using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursun : MonoBehaviour
{
    Rigidbody _kursunFizik;
    public float _mermiHiz;
    void Start()
    {
        _kursunFizik = GetComponent<Rigidbody>();
        _kursunFizik.velocity = transform.forward *_mermiHiz;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
