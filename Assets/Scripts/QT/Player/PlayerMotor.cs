using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    [SerializeField]
    private float _speed = 10.0f;
    private Rigidbody2D _rb;

    // Use this for initialization
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }



    public void Marche(Vector2 direction)
    {
        _rb.velocity = direction * _speed * Time.fixedDeltaTime;
    }
}
