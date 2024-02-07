using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotasyon : MonoBehaviour
{
    Rigidbody _metorFizik;
    public float hýz;
    public float _metorGelis;

    public GameObject _meteorPartikul;
    public GameObject _playerPartukul;
    GameObject _gameManager;
    Game_Manager _Manager;
     void Start()
    {
        _metorFizik = GetComponent<Rigidbody>();

        _gameManager = GameObject.FindGameObjectWithTag("gameManager");
        _Manager = _gameManager.GetComponent<Game_Manager>();

        _metorFizik.angularVelocity = Random.insideUnitSphere*hýz;
        _metorFizik.velocity = transform.forward * -_metorGelis;
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "sýnýr")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(_meteorPartikul, transform.position, transform.rotation);
            _Manager.scorArttýr(10);
        }

        if (other.tag == "Player")
        {
            Instantiate(_playerPartukul, other.transform.position, other.transform.rotation);
            _Manager.gameOver();
        }
    }



}
