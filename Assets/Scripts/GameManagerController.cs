using UnityEngine;
using UnityEngine.UI;

public class GameManagerController : MonoBehaviour
{
    [SerializeField] private Text distancia_B_A;
    [SerializeField] private Text distancia_B_Origen;
    [SerializeField] private Transform ObjetoA;
    [SerializeField] private Transform ObjetoB;
    private Vector3 origen = new Vector3(0, 0, 0);
    void Update()
    {
        distancia_B_A.text = "La distancia del Objeto B respecto al Objeto A es: " + Vector2.Distance(ObjetoB.position, ObjetoA.position);
        distancia_B_Origen.text = "La distancia del Objeto B respecto al Punto de Origen es: " + Vector2.Distance(ObjetoB.position, origen);
    }
}

