using UnityEngine;

public class Spell_charge : MonoBehaviour
{
    [SerializeField] private MeshFilter mesh;

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * -30, 0, Space.Self);
    }
}
