using UnityEngine;

public class Spell_charge : MonoBehaviour
{
    [SerializeField] public MeshFilter mesh;

    public static Spell_charge Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * -30, 0, Space.Self);
    }

    public void Modif_Mesh(Mesh new_mesh)
    {
        mesh.mesh = new_mesh;
    }
}
