using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private Transform _compTransform;
    [SerializeField] private float direccionHorizontal;
    [SerializeField] private float direccionVertical;
    [SerializeField] private int velocidad;

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        direccionHorizontal = Input.GetAxisRaw("Horizontal");
        direccionVertical = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        //Movimiento
        Vector2 direccion = new Vector2(direccionHorizontal, direccionVertical);
        _compRigidbody2D.velocity = direccion * velocidad;
    }
}
