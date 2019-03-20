using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private PlayerMotor _direction = null;
    private Interactable interactable;
    public ShowDescription descriptionGiver;
    public List<Interactable> triggered = new List<Interactable>();

    private void Update()
    {
        foreach(Interactable _object in triggered)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _object.AddNewItem(_object);
                return;
            }
        }
    }

    // Use this for initialization
    void Awake()
    {
        _direction = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        Vector2 horizontalDirection = Vector2.right * horizontalAxis;
        Vector2 verticalDirection = Vector2.up * verticalAxis;
        Vector2 direction = horizontalDirection + verticalDirection;
        direction.Normalize();
        _direction.Marche(direction);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Interactable interactable = other.GetComponent<Interactable>();
        if (interactable)
        {
            Debug.Log("Add interac" + other.name);
            triggered.Add(interactable);
            descriptionGiver.DescriptionGiver(interactable);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Interactable interactable = other.GetComponent<Interactable>();
        if (interactable)
        {
            Debug.Log("Remove interac" + other.name);
            triggered.Remove(interactable);
            descriptionGiver.DestroyPannel();
        }
    }
}
