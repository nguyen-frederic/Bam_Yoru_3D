using UnityEngine;

public class Spell : MonoBehaviour
{
    public string forme;
    public Material couleur;

    [SerializeField] private float vitesse;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * vitesse * Time.fixedDeltaTime);
    }
}
