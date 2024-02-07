using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL_MOVE : MonoBehaviour
{
    Rigidbody _fizik;
    float _Horizontal = 0;
    float _Vertical = 0;
    [Header("Player hýz ve eðim")]
    public float _Plhýz;
    public float _egeim;

    Vector3 _Vector;

    [Header("PLAYER GÝDECEÝÐÝ SINIRLAR")]
    public float _minX;
    public float _maxX;
    public float _minZ;
    public float _maxZ;

    float _atesZamani = 0;

    public float _atesGecenSure;

    public GameObject _Kursun;

    public Transform _kursunYeri;

    AudioSource _plSes;
   

    void Start()
    {
        _fizik=GetComponent<Rigidbody>();

        _plSes=GetComponent<AudioSource>();
        
    }



    void FixedUpdate()
    {
       

        //ateþ yer ateþ yeri
        if (Input.GetButton("Jump") && Time.time>_atesZamani)
        {
            _atesZamani = Time.time + _atesGecenSure;
            _plSes.Play();
            Instantiate(_Kursun, _kursunYeri.position, Quaternion.identity);
        }

        //geminin hareket yeri
        _Horizontal = Input.GetAxis("Horizontal");
        _Vertical = Input.GetAxis("Vertical");

        _Vector = new Vector3(_Horizontal, 0, _Vertical);

        _fizik.velocity = _Vector * _Plhýz;
        //<*********>

        //burasýda  sýnýr çiziyoruz
        _fizik.position = new Vector3
            (Mathf.Clamp(_fizik.position.x, _minX, _maxX),0.0f,
            Mathf.Clamp(_fizik.position.z, _minZ, _maxZ)

            );
        _fizik.rotation = Quaternion.Euler(0, 0, _fizik.velocity.x);
    }

  
}
