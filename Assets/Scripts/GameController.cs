using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text transform_position;
    [SerializeField] private Text transform_scale;
    [SerializeField] private Text transform_rotation;
    [SerializeField] private Text transform_localPosition;
    [SerializeField] private Text transform_localScale;
    [SerializeField] private Text transform_localRotation;
    [SerializeField] private PlayerController jugador;
    void Update()
    {
        transform_position.text = "Transform.Position: " + jugador.transform.position;
    }
}
