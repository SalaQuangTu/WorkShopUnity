using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour {

    public EnemiesMotor motor;
    public List<GameObject> patern = new List<GameObject>();
    public GameObject target;
    public int MaxPaternPoint = 0;
    public int currentPaternPoint = 0;

    private void Awake()
    {
        MaxPaternPoint = patern.Count;
        target = patern[currentPaternPoint];
    }

    private void Update()
    {
        Vector2 _direction = target.transform.position - transform.position;
        motor.Marche(_direction.normalized);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "CheckPoint")
        {
            currentPaternPoint = currentPaternPoint < MaxPaternPoint - 1 ? currentPaternPoint + 1 : 0;
        }
        target = patern[currentPaternPoint];
    }
}